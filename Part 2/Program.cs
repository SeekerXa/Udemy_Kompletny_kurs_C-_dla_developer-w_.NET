using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int yearOfBirth;
            if (int.TryParse(userInput, out yearOfBirth))
            {
                int age = DateTime.Now.Year - yearOfBirth;
                Console.WriteLine($"User ages is : {age} ");
            }
            else
            {
                Console.WriteLine("Incorrect Value");
            }
            byte byteValue = 100;
            int intValue = byteValue;
            byte byteValue2 = (byte)intValue;
            double doubleValue = 3.5;
            int intValue2 = (int)doubleValue;  //= 3 .
          



        }
    }
}
