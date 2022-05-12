using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_DataParsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your brithdate: ");
            string dateEnteredByUser = Console.ReadLine();
           
            DateTime now= DateTime.Now;
            DateTime dateOfBirth= DateTime.Parse(dateEnteredByUser);
           
          
            Console.WriteLine(now.ToString());
            Console.WriteLine (dateOfBirth.ToString());

           
            int sum = 0;
            Console.WriteLine(DateTime.Equals(dateOfBirth, now));

            DateTime tempDateOfBirth = dateOfBirth;


            //using a function
            TimeSpan howmanyDays = DateTime.Now - dateOfBirth;  
            Console.WriteLine("User Lives from days ( by DateSpan): " + howmanyDays.TotalDays);


            // by iteration
            while ((tempDateOfBirth.Year != now.Year) || ((tempDateOfBirth.Month != now.Month)) || (tempDateOfBirth.Day != now.Day))
            {
                sum++;

                tempDateOfBirth = tempDateOfBirth.AddDays(1);
            }
            Console.WriteLine("User lives from days " + sum);
        }
    }

}
