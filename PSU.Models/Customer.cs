using EnsureThat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSU.Models
{
    public class Customer
    {
        //Other properties for Customer
        public List<Contact> Contacts { get; private set; } = new List<Contact>();

        /// <summary>
        /// Will add a contact to the contacts list. If a contact with the email already exists it is not added
        /// </summary>
        /// <param name="contact">A valid contact object</param>
        public void AddContact(Contact contact)
        {
            Ensure.That(contact, nameof(contact)).IsNotNull();
            if (!Contacts.Any(x => x.Email == contact.Email))
            {
                Contacts.Add(contact);
            }
        }
    }
}


