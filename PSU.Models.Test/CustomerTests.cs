using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSU.Models.Test
{    
    public class CustomerTests
    {
        [Test]
        public void AddInvalidContact_ExpectException()
        {
            //Arrange
            Customer customer = new Customer();
            Contact contact = null;
            //Act, Assert
            Assert.Throws<ArgumentNullException>(() => customer.AddContact(contact));
        }

        [Test]
        public void AddSameContactTwice_ExpectOnlyOneInList()
        {
            //Arrange
            Customer customer = new Customer();
            Contact contact = new Contact("Brian", "Email");
            //Act
            customer.AddContact(contact);
            customer.AddContact(contact);
            //Assert
            Assert.That(1, Is.EqualTo(customer.Contacts.Count));
        }
    }
}
