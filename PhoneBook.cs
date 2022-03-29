using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPhoneBookContacts
{
    public class PhoneBook
    {
        private List<Contact> _contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public void DisplayContactByNumber(string number)
        {
            var chosedContact = _contacts.FirstOrDefault(x => x.Number == number);
            if (chosedContact == null)
            {
                Console.WriteLine("Contact not found!");
            }
            else
            {
                Console.WriteLine($"Contact: {chosedContact.Name}, {chosedContact.Number}");
            }
        }

        public void DisplayContactByName(string name)
        {
            var chosedContact = _contacts.Where(x => x.Name == name).FirstOrDefault();
            if (chosedContact == null)
            {
                Console.WriteLine("Contact not found!");
            }
            else
            {
                Console.WriteLine($"Contact: {chosedContact.Name}, {chosedContact.Number}");
            }
        }

        public void DisplayAllContacts()
        {
            foreach (var contact in _contacts)
            {
                Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
            }
        }
    }
}
