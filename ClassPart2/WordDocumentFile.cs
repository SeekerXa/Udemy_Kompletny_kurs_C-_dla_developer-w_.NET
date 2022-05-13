using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPart2
{
    internal class WordDocumentFile : File
    {
        public void GenerateReport()
        {
            Console.WriteLine($"{FileName} Printing..");
        }

        public WordDocumentFile(string fileName, int size, DateTime date)
        {
            FileName = fileName;
            Size = size;
            CreateOn = date;
        }


    }
}
