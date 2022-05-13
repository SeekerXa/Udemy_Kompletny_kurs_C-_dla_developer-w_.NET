using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPart2
{
    abstract class File
    {
        public string FileName { get; set; }    
        public int Size { get; set; }
        public DateTime CreateOn { get; set; }

      
    }
}
