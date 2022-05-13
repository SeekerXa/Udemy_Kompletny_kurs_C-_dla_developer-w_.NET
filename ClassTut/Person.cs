using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTut
{
    internal class Person
    {
        public static int Count = 0;
        public string FirstName;
        public string LastName;
        DateTime dateOfBirth;
        string contactNumber;

        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                if (value.Length > 9 && value.Length < 9)
                {
                    Console.WriteLine("Wrong number");
                }
                else contactNumber = value;
            }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                if (value > DateTime.Now)
                {
                    Console.WriteLine("Invaild date if birth");
                }
                else dateOfBirth = value;
            }
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Count++;
        }

        public Person(string firstName, string lastName, DateTime date) : this(firstName, lastName)
        {
            DateOfBirth = date;
        }

    

        public DateTime GetDateOfBirth() => dateOfBirth;

        public void SayHi()
        {
            Console.WriteLine($"Hi, I'm {FirstName}, {GetDateOfBirth()}");
        }



    }
}
