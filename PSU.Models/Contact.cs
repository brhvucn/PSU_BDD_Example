using EnsureThat;

namespace PSU.Models
{
    public class Contact
    {
        public Contact(string name, string email)
        {
            Ensure.That(name, nameof(name)).IsNotNullOrWhiteSpace();
            Ensure.That(email, nameof(email)).IsNotNullOrWhiteSpace();            
            this.Name = name;
            this.Email = email;
        }
        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}
