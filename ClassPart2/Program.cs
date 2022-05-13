using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {

           ExcelFile excelFile = new ExcelFile("taki",23,DateTime.Now);

           PowerPointFile powerFile = new PowerPointFile("taki", 23, DateTime.Now);

            excelFile.GenerateReport();
            powerFile.GenerateReport();

        }
    }
}
