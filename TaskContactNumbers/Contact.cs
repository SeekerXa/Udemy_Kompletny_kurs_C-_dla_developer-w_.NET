using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskContactNumbers
{
    internal class Contact
    {
        public string Number;
        public string Name;

        int Count = 0;

        public Contact(string name, string number)
        {
            Number = number;
            Name = name;
            Count++;
        }

        ~Contact()
        {
            Count--;
        }


        public override string ToString() => $"{Name} : {Number}, ";



    }



}
