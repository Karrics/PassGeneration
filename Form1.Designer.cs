namespace PassGeneration
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Exit_Button = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkNonLetter = new System.Windows.Forms.CheckBox();
            this.checSimilar = new System.Windows.Forms.CheckBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit_Button
            // 
            this.Exit_Button.AutoSize = true;
            this.Exit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_Button.Location = new System.Drawing.Point(828, 9);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(23, 22);
            this.Exit_Button.TabIndex = 0;
            this.Exit_Button.Text = "X";
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            this.Exit_Button.MouseLeave += new System.EventHandler(this.Exit_Button_MouseLeave);
            this.Exit_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Exit_Button_MouseMove);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(181)))), ((int)(((byte)(122)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox1.Location = new System.Drawing.Point(277, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(263, 42);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Генератор пароля";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            this.textBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(181)))), ((int)(((byte)(179)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.checkNonLetter);
            this.panel1.Controls.Add(this.checSimilar);
            this.panel1.Controls.Add(this.passBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 355);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.comboBox1.Location = new System.Drawing.Point(706, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 27);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Длинна пароля";
            // 
            // checkNonLetter
            // 
            this.checkNonLetter.AutoSize = true;
            this.checkNonLetter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkNonLetter.Location = new System.Drawing.Point(25, 127);
            this.checkNonLetter.Name = "checkNonLetter";
            this.checkNonLetter.Size = new System.Drawing.Size(258, 61);
            this.checkNonLetter.TabIndex = 4;
            this.checkNonLetter.Text = "исключить небуквенные символы\r\n ({ } [ ] ( ) / \\ \'\r\n\" ` ~ , ; : . < >).";
            this.checkNonLetter.UseVisualStyleBackColor = true;
            // 
            // checSimilar
            // 
            this.checSimilar.AutoSize = true;
            this.checSimilar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checSimilar.Location = new System.Drawing.Point(25, 60);
            this.checSimilar.Name = "checSimilar";
            this.checSimilar.Size = new System.Drawing.Size(206, 42);
            this.checSimilar.TabIndex = 3;
            this.checSimilar.Text = "исключить похожие\r\nсимволы (i, l, 1, L, o, 0, O),\r\n";
            this.checSimilar.UseVisualStyleBackColor = true;
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(98)))), ((int)(((byte)(97)))));
            this.passBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.passBox.Location = new System.Drawing.Point(298, 127);
            this.passBox.Multiline = true;
            this.passBox.Name = "passBox";
            this.passBox.ReadOnly = true;
            this.passBox.Size = new System.Drawing.Size(354, 37);
            this.passBox.TabIndex = 1;
            this.passBox.Text = "Тут будет ваш пароль";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(181)))), ((int)(((byte)(122)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(357, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сгенерировать";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(98)))), ((int)(((byte)(97)))));
            this.textBox2.Location = new System.Drawing.Point(298, 50);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(354, 37);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Введите логин";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(181)))), ((int)(((byte)(122)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(627, 280);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(170, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Сохранить пароль";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(863, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Exit_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exit_Button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.CheckBox checkNonLetter;
        private System.Windows.Forms.CheckBox checSimilar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
    }
}

