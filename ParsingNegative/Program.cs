using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingNegative
{
    internal class Program
    {
        public static int TryNegativeParsing(string input,out int result)
        {
            if (int.TryParse(input, out result))
            {

            }
            else
            {

            }


        }

        public static bool IsNegative(int x) => x < 0;
    




        static void Main(string[] args)
        {


            TryNegativeParsing("-22");
        }
    }                                                                
}
