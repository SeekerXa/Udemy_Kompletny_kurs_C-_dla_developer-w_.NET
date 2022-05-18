using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    internal class Person
    {
        public string FirstName;
        public string LastName;
        private DateTime dateOfBirth;
        private string contactNumber;
        public static int Count = 0;

        public string ContactNumber { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Count++;
        }

        public Person(DateTime dateOfBirth, string firstName, string lastName) : this(firstName, lastName)
        {
            SetDateOfBirth(dateOfBirth);
        }

        public void SetDateOfBirth(DateTime date)
        {
            if (date > DateTime.Now)
            {
                Console.WriteLine("Invalid date of birth");
            }
            else
                dateOfBirth = date;
        }

        public DateTime GetDateOfBirth() => dateOfBirth;

        public void SayHi()
        {
            Console.WriteLine($"Hi,I'm {FirstName}{LastName}, {GetDateOfBirth()}");
        }

    }
}
