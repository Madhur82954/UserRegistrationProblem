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
            bool isvalidFirstName = p.validFirstName(Firstname);
            bool isvalidLastName = p.validLastName(Lastname);
            bool isvalidPhoneNo = p.validPhoneno(Phoneno);
            bool isvalidEmail = p.validEmail(Email);
            bool isvalidPassword = p.validPassword(Password);

            // Assert
            Assert.IsTrue(isvalidFirstName);
            Assert.IsTrue(isvalidLastName);
            Assert.IsTrue(isvalidPhoneNo);
            Assert.IsTrue(isvalidEmail);
            Assert.IsTrue(isvalidPassword);
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
            bool isvalidFirstName = p.validFirstName(Firstname);
            bool isvalidLastName = p.validLastName(Lastname);
            bool isvalidPhoneNo = p.validPhoneno(Phoneno);
            bool isvalidEmail = p.validEmail(Email);
            bool isvalidPassword = p.validPassword(Password);

            // Assert
            Assert.IsFalse(isvalidFirstName);
            Assert.IsFalse(isvalidLastName);
            Assert.IsFalse(isvalidPhoneNo);
            Assert.IsFalse(isvalidEmail);
            Assert.IsFalse(isvalidPassword);
        }
        [TestMethod]
        [DataRow("itzmadhurverma@gmail.com")]
        [DataRow("vishalgarg@gmail.com")]
        public void EnterMultipleEmails(string Email)
        {
            //Arrange
            Program p = new Program();
            //Act
            bool isvalidEmail = p.validEmail(Email);
            //Assert
            Assert.IsTrue(isvalidEmail);
        }
    }
}
