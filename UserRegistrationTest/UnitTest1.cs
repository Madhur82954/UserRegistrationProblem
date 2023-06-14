using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblem;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestValidUsers()
        {
            // Arrange
            Program p = new Program();

            string Firstname = "Madhur";
            string Lastname = "Verma";
            string Phoneno = "91 8295475016";
            string Email = "itzmadhurverma@gmail.com";
            string Password = "Madhur@123";

            // Act
            try
            {
                p.validFirstName(Firstname);
                p.validLastName(Lastname);
                p.validPhoneno(Phoneno);
                p.validEmail(Email);
                p.validPassword(Password);
            }
            catch (InvalidUserException ex)
            {
                // Assert
                Assert.Fail("Exception message :" + ex.Message);
            }
        }
        [TestMethod]
        public void TestInvalidUsers()
        {
            // Arrange
            Program p = new Program();

            string Firstname = "Jka123";
            string Lastname = "Kj@l";
            string Phoneno = "8923901238";
            string Email = "asjkdiqwegmail.com";
            string Password = "Mjasd";

            // Act
            try
            {
                p.validFirstName(Firstname);
                p.validLastName(Lastname);
                p.validPhoneno(Phoneno);
                p.validEmail(Email);
                p.validPassword(Password);
            }
            catch (InvalidUserException ex)
            {
                // Assert
                Assert.Fail("Exception  Message :" + ex.Message);
            }
        }
        public void TestEnterMultipleEmails()
        {
            //Arrange
            Program p = new Program();
            string[] email = { "itzmadhurverma@gmail.com","vishalgarg@gmail.com","namansingh@gmail.com" };
            //Act
            foreach (string e in email)
            {
                try
                {
                    p.validEmail(e);
                }//Assert
                catch (InvalidUserException ex)
                {
                    Assert.Fail("Exception Message is :" + ex.Message);
                }
            }
        }
    }
}
