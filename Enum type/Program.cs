using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your gender 1 = men, 2 = female:");
            string answer = Console.ReadLine();
           
            Gender userGender = (Gender)Enum.Parse(typeof(Gender),answer);
           
            if(userGender == Gender.Male)
            {
                Console.WriteLine("only woman allow");
            }
            else
            {
                Console.WriteLine("Hi");
            }


        }
    }
}
