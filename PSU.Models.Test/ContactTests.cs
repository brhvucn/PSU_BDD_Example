
namespace PSU.Models.Test
{
    public class ContactTests
    {        
        [Test]
        public void TestCreateContact_ValidName_ValidEmail_ExpectSuccess()
        {
            //Arrange
            string name = "Brian";
            string email = "brhv@ucn.dk";
            // Act
            Contact myContact = new Contact(name, email);
            //Assert
            Assert.That(name, Is.EqualTo(myContact.Name));
            Assert.That(email, Is.EqualTo(myContact.Email));
        }

        [TestCase("", "brhv@ucn.dk")]
        [TestCase("Brian", "")]
        public void TestCreateContact_InvalidArguments_ExpectException(string name, string email)
        {
            //Arrange,
            ////Act, Assert
            Assert.Throws<ArgumentException>(() => new Contact(name, email));
        }

        [TestCase(null, "brhv@ucn.dk")]
        [TestCase("Brian", null)]
        public void TestCreateContact_InvalidNullArguments_ExpectException(string? name, string? email)
        {
            //Arrange,
            ////Act, Assert
            Assert.Throws<ArgumentNullException>(() => new Contact(name, email));
        }
    }
}
