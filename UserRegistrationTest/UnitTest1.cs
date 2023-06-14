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
            Program program = new Program();
            bool isvalidFirstName = program.validFirstName(Firstname);
            bool isvalidLastName = program.validLastName(Lastname);
            bool isvalidPhoneNo = program.validPhoneno(Phoneno);
            bool isvalidEmail = program.validEmail(Email);
            bool isvalidPassword = program.validPassword(Password);

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

            string Firstname = "Madhur";
            string Lastname = "Verma";
            string Phoneno = "91 8295475016";
            string Email = "itzmadhurverma@gmail.com";
            string Password = "Madhur@123";

            // Act
            Program program = new Program();
            bool isvalidFirstName = program.validFirstName(Firstname);
            bool isvalidLastName = program.validLastName(Lastname);
            bool isvalidPhoneNo = program.validPhoneno(Phoneno);
            bool isvalidEmail = program.validEmail(Email);
            bool isvalidPassword = program.validPassword(Password);

            // Assert
            Assert.IsFalse(isvalidFirstName);
            Assert.IsFalse(isvalidLastName);
            Assert.IsFalse(isvalidPhoneNo);
            Assert.IsFalse(isvalidEmail);
            Assert.IsFalse(isvalidPassword);
        }
    }
}
