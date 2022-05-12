using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 0;
            int enteredNumber = 1;
            int sum = 0;
            Console.Write("Enter a number: ");
            while (enteredNumber != 0)
            {
                string stringToParse = Console.ReadLine();
                if (int.TryParse(stringToParse, out enteredNumber))
                {
                    Console.Write("Enter a number: ");
                    maxNumber = Math.Max(maxNumber, enteredNumber);
                    sum += enteredNumber;
                }
                else
                {
                    Console.Write("Wrong data type!\n Try again :");
                    enteredNumber = 1;
                }
            }

            Console.WriteLine("Biggest number u write: " + maxNumber);
            Console.WriteLine("All number sum: " + sum);

        }
    }
}
