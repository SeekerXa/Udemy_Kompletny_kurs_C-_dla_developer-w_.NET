using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPart2
{
    internal class ExcelFile : iFile
    {

        public string FileName { get; set; }
        public int Size { get; set; }
        public DateTime CreateOn { get; set; }

        public ExcelFile(string fileName, int size, DateTime date)
        {
            FileName = fileName;
            Size = size;
            CreateOn = date;
        }

        public void GenerateReport()
        {
            Console.WriteLine($"{FileName} report..");
        }


    }
}
