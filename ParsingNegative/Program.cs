using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingNegative
{
    internal class Program
    {
        public static bool TryParseToNegativeInt(string input, out int result)
        {
            if (int.TryParse(input, out result))
            {
                if (result < 0)
                {
                    return true;
                }
                else return false;
            }
            else
            {
                result = default;
                return false;

            }


        }

        public static bool IsNegative(int x) => x < 0;





        static void Main(string[] args)
        {

            int inpytValue;
            while (!TryParseToNegativeInt(Console.ReadLine(),out inpytValue))
            {
                     Console.WriteLine("insert negative number!");
            }
            Console.WriteLine($"Inserted negative number = {inpytValue}");
        }
    }                                                       
}
