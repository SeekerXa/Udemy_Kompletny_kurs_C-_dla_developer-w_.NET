using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPart2
{
    interface iFile
    {
        string FileName { get; set; }    
        int Size { get; set; }
        DateTime CreateOn { get; set; }

      
    }
}

