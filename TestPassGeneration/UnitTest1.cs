using Microsoft.VisualStudio.TestTools.UnitTesting;
using PassGeneration;
using System;

namespace TestPassGeneration
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GeneratePassword_ReturnsPasswordWithCorrectLength()
        {

            int length = 10;
            bool includeSimilarChars = true;
            bool includeNonAlphaNumericChars = true;


            string password = Form1.GeneratePassword(length, includeSimilarChars, includeNonAlphaNumericChars);


            Assert.AreEqual(length, password.Length);
        }

        [TestMethod]
        public void GeneratePassword_DoesNotContain_SimilarChars()
        {
            int length = 12;
            bool includeSimilarChars = false;
            bool includeNonAlphaNumericChars = true;

            string password = Form1.GeneratePassword(length, includeSimilarChars, includeNonAlphaNumericChars);

            Assert.IsFalse(password.Contains("0"));
            Assert.IsFalse(password.Contains("i"));
            Assert.IsFalse(password.Contains("l"));
            Assert.IsFalse(password.Contains("1"));
            Assert.IsFalse(password.Contains("L"));
            Assert.IsFalse(password.Contains("o"));
            Assert.IsFalse(password.Contains("O"));
        }

        [TestMethod]
        public void GeneratePassword_DoesNotContain_NonAlphaNumericChars()
        {
            int length = 15;
            bool includeSimilarChars = true;
            bool includeNonAlphaNumericChars = false;


            string password = Form1.GeneratePassword(length, includeSimilarChars, includeNonAlphaNumericChars);



            Assert.IsFalse(password.Contains(")"));
            Assert.IsFalse(password.Contains("("));
            Assert.IsFalse(password.Contains("{"));
            Assert.IsFalse(password.Contains("}"));
            Assert.IsFalse(password.Contains("["));
            Assert.IsFalse(password.Contains("]"));
            Assert.IsFalse(password.Contains("|"));
            Assert.IsFalse(password.Contains("/"));
            Assert.IsFalse(password.Contains(","));
            Assert.IsFalse(password.Contains("."));
            Assert.IsFalse(password.Contains("<"));
            Assert.IsFalse(password.Contains(">"));
            Assert.IsFalse(password.Contains("!"));
            Assert.IsFalse(password.Contains("@"));
            Assert.IsFalse(password.Contains("#"));
            Assert.IsFalse(password.Contains("$"));
            Assert.IsFalse(password.Contains("%"));
            Assert.IsFalse(password.Contains("&"));
        }

        [TestMethod]
        public void GeneratePassword_DoesNotContain()
        {
            int length = 15;
            bool includeSimilarChars = false;
            bool includeNonAlphaNumericChars = false;


            string password = Form1.GeneratePassword(length, includeSimilarChars, includeNonAlphaNumericChars);



            Assert.IsFalse(password.Contains(")"));
            Assert.IsFalse(password.Contains("("));
            Assert.IsFalse(password.Contains("{"));
            Assert.IsFalse(password.Contains("}"));
            Assert.IsFalse(password.Contains("["));
            Assert.IsFalse(password.Contains("]"));
            Assert.IsFalse(password.Contains("|"));
            Assert.IsFalse(password.Contains("/"));
            Assert.IsFalse(password.Contains(","));
            Assert.IsFalse(password.Contains("."));
            Assert.IsFalse(password.Contains("<"));
            Assert.IsFalse(password.Contains(">"));
            Assert.IsFalse(password.Contains("!"));
            Assert.IsFalse(password.Contains("@"));
            Assert.IsFalse(password.Contains("#"));
            Assert.IsFalse(password.Contains("$"));
            Assert.IsFalse(password.Contains("%"));
            Assert.IsFalse(password.Contains("&"));
            Assert.IsFalse(password.Contains("0"));
            Assert.IsFalse(password.Contains("i"));
            Assert.IsFalse(password.Contains("l"));
            Assert.IsFalse(password.Contains("1"));
            Assert.IsFalse(password.Contains("L"));
            Assert.IsFalse(password.Contains("o"));
            Assert.IsFalse(password.Contains("O"));
        }

        [TestMethod]
        public void GeneratePassword_ReturnsPasswordWithCorrectLength2()
        {

            int length = 0;
            bool includeSimilarChars = true;
            bool includeNonAlphaNumericChars = true;


            string password = Form1.GeneratePassword(length, includeSimilarChars, includeNonAlphaNumericChars);


            Assert.AreEqual(length, password.Length);
        }
    }
}

