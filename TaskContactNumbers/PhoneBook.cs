using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskContactNumbers
{
    internal class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
            DispalyContactDetails(contact);
        }

        private void DispalyContactDetails(Contact contact)
        {
            Console.WriteLine(contact);
        }
        private void DispalyContactDetails(List<Contact> contact)
        {
            foreach (var i in contact)
            {
                DispalyContactDetails(i);
            }
        }



        public void DispalyContact(string number)
        {
            var contact = Contacts.FirstOrDefault(x => x.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact not found");

            }
            else
            {
                DispalyContactDetails(contact);
            }

        }

        public void DisplayAllContacts()
        {
            DispalyContactDetails(Contacts);
        }

        public void DispalyContactByName(string phrase)
        {
            var matchingContacts = Contacts.Where(x => x.Name.Contains(phrase)).ToList();
            DispalyContactDetails(matchingContacts);

        }

        public void DeleteContact(string number)
        {

            Contacts.Remove(Contacts.FirstOrDefault(x => x.Number == number));


        }

    }
}
