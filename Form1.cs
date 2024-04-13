using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGeneration
{
    public partial class Form1 : Form
    {
        private int minLenght = 8;
        private int maxLength = 30;

        public Form1()
        {
            InitializeComponent();
        }

        Point point;
        public static string GeneratePassword(int length, bool includeSimilarChars, bool includeNonAlphaNumericChars)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHJKLMNPRSTUVWXYZabcdefghijkmnpqrstuvwxyz0123456789!@#$%^&*_-+=?";
            const string similarChars = "il1Lo0O";
            const string nonAlphaNumericChars = "{}[]()/\\'\"`~,;:.<>!@#$%&";
            string usableChars = chars;

            if (!includeSimilarChars)
            {
                foreach (char similarChar in similarChars)
                {
                    usableChars = usableChars.Replace(similarChar.ToString(), string.Empty);
                }
            }

            if (!includeNonAlphaNumericChars)
            {
                usableChars += nonAlphaNumericChars;
            }

            StringBuilder password = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                password.Append(usableChars[random.Next(usableChars.Length)]);
            }


            string filePath = "rockyou.txt";
            if (File.Exists(filePath))
            {
                foreach (string line in File.ReadLines(filePath))
                {
                    if (string.Equals(line, password))
                    {
                        return "0";
                    }
                }
            }
            return password.ToString();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exit_Button_MouseMove(object sender, MouseEventArgs e)
        {
            Exit_Button.ForeColor = Color.Red;
        }

        private void Exit_Button_MouseLeave(object sender, EventArgs e)
        {
            Exit_Button.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lenght = 0;
            string password = "0";
            if (comboBox1.SelectedItem != null)
            {
                 lenght = int.Parse(comboBox1.SelectedItem.ToString());
            }
            else
            {
                password = "0"; 
            }
            
            password = GeneratePassword(lenght, checSimilar.Checked, checkNonLetter.Checked);
            passBox.Text = password;
            passBox.ForeColor = Color.Black;
            if (password == "0")
            {
                MessageBox.Show("Ошибка генерации пароля \nПопробуйте снова");
            }
            button2.Visible = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textToSave = "Логин - " + textBox2.Text + Environment.NewLine + "Пароль - " + passBox.Text;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.Write(textToSave);
                }
                MessageBox.Show("Пароль успешно сохранён!", "Хорошо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
