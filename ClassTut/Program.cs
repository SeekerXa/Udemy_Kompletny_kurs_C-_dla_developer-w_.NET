using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person("Bill", "Whick", new DateTime(1999, 1, 1));

            bill.SayHi();
            bill.ContactNumber = "123345567";

            Console.WriteLine(Person.Count);


        }

    }
}
