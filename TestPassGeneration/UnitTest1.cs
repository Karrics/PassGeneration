using NUnit.Framework;
using PassGeneration;

namespace TestPassGeneration
{
    [TestFixture]
    public class Form1Tests
    {
        [Test]
        public void GeneratePassword_Returns_Password_With_Correct_Length()
        {

            int length = 10;
            bool includeSimilarChars = true;
            bool includeNonAlphaNumericChars = true;


            string password = Form1.GeneratePassword(length, includeSimilarChars, includeNonAlphaNumericChars);


            Assert.AreEqual(length, password.Length);
        }

        [Test]
        public void GeneratePassword_Does_Not_Contain_SimilarChars()
        {
            int length = 12;
            bool includeSimilarChars = false;
            bool includeNonAlphaNumericChars = true;

            string password = Form1.GeneratePassword(length, includeSimilarChars, includeNonAlphaNumericChars);

            StringAssert.DoesNotContain("i", password);
            StringAssert.DoesNotContain("l", password);
            StringAssert.DoesNotContain("1", password);
            StringAssert.DoesNotContain("L", password);
            StringAssert.DoesNotContain("o", password);
            StringAssert.DoesNotContain("0", password);
            StringAssert.DoesNotContain("O", password);
        }

        [Test]
        public void GeneratePassword_Does_Not_Contain_Non_AlphaNumericChars()
        {
            int length = 15;
            bool includeSimilarChars = true;
            bool includeNonAlphaNumericChars = false;


            string password = Form1.GeneratePassword(length, includeSimilarChars, includeNonAlphaNumericChars);


            StringAssert.DoesNotContain("{", password);
            StringAssert.DoesNotContain("}", password);
            StringAssert.DoesNotContain("[", password);
            StringAssert.DoesNotContain("]", password);
            StringAssert.DoesNotContain("(", password);
            StringAssert.DoesNotContain(")", password);
            StringAssert.DoesNotContain("/", password);
            StringAssert.DoesNotContain("`", password);
            StringAssert.DoesNotContain("~", password);
            StringAssert.DoesNotContain(",", password);
            StringAssert.DoesNotContain(";", password);
            StringAssert.DoesNotContain(":", password);
            StringAssert.DoesNotContain(".", password);
            StringAssert.DoesNotContain("<", password);
            StringAssert.DoesNotContain(">", password);
            StringAssert.DoesNotContain("!", password);
            StringAssert.DoesNotContain("@", password);
            StringAssert.DoesNotContain("#", password);
            StringAssert.DoesNotContain("$", password);
            StringAssert.DoesNotContain("%", password);
            StringAssert.DoesNotContain("&", password);
        }
    }
}