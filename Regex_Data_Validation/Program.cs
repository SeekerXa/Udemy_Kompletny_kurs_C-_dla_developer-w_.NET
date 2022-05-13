using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Regex_Data_Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Regex regex = new Regex(@"^[a-z0-9]+\w.?[a-z0-9]+@[a-z0-9]+\.[a-z]{2,3}$");

            string email = "test_t2@gmail.com";
            
            Console.WriteLine(regex.IsMatch(email));
        }
    }
}
