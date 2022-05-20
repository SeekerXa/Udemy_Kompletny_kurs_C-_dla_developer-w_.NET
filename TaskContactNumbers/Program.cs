using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskContactNumbers
{
    internal class Program
    {
        static Contact CreateContact()
        {
            string tempName;
            string tempNumber;
            do
            {
                Console.Write("Enter Name(at least 3 char): ");
                tempName = Console.ReadLine();
                Console.Write("Enter Number(9 digits): ");
                tempNumber = Console.ReadLine();
                Console.WriteLine();
            }
            while ((tempName.Length < 3) || (tempNumber.Length != 9));

            var newContact = new Contact(tempName, tempNumber);
            return newContact;
        }




        static void Main(string[] args)
        {
            var Book = new List<Contact>();

            var phoneBook = new PhoneBook();


            string useranswer = "0";


            while (useranswer != "x")
            {
                Console.WriteLine("\nContactsBook.");
                Console.WriteLine("Press '1' to Add new contact\n" +
              "Press '2' to wiew contact by number\n" +
              "press '3' to wiew all contact \n" +
              "press '4' to search\n" +
              "press '5' to delete number\n" +
              "press 'x' to exit\n");

                Console.Write("\nChoose your action: ");
                useranswer = Console.ReadLine();
                switch (useranswer)
                {
                    case "1":
                        {
                            phoneBook.AddContact(CreateContact());

                            break;
                        }
                    case "2":
                        {
                            Console.Write("Enter a number to view conntact: ");
                            phoneBook.DispalyContact(Console.ReadLine());
                            break;
                        }

                    case "3":
                        {
                            phoneBook.DisplayAllContacts();
                            break;
                        }

                    case "4":
                        {
                            Console.Write("Enter a phase to view conntact: ");
                            phoneBook.DispalyContactByName(Console.ReadLine());
                            break;
                        }
                    case "5":
                        {
                            Console.Write("Enter a number to delete: ");
                            phoneBook.DeleteContact(Console.ReadLine());
                            break;
                        }

                    case "x":
                        {
                            break;
                        }
                    default:
                        Console.WriteLine("Wrong operation");

                        break;

                }
            }



        }
    }
}
