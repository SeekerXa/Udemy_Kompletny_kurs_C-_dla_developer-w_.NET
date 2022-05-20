using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldInsteadOfReturn
{
    internal class Program
    {
        public static IEnumerable<int> GetYieldedData()
        {
            Console.WriteLine("Start GetYield");

            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine($"Add GetYield {i}");
                yield return i;

                if (i % 3 == 0)
                {
                    yield break;
                }
            }
            Console.WriteLine("END GetYield");
        }

        public static IEnumerable<int> GetData()
        {
            Console.WriteLine("Start Get");
            var result = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Adding to list {i}");
                result.Add(i);
            }
            return result;
            Console.WriteLine("END Get");
        }



        static void Main(string[] args)
        {
            var yieldedData = GetYieldedData();

            foreach (int i in yieldedData)
            {
                Console.WriteLine($"Main element: {i}");
                if (i > 5)
                {
                    break;
                }
            }



        }

    }
}
