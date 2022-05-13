using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPart2
{
    internal class PowerPointFile  : File
    {
       public void GenerateReport()
        {
            Console.WriteLine($"{FileName} prezents..");
        }

        public PowerPointFile(string fileName, int size, DateTime date)
        {
            FileName = fileName;
            Size = size;
            CreateOn = date;
        }



    }
}
