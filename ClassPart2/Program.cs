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

            Shape[] shapes = { new Circle(), new Rectangle(), new Triangle(), };

            foreach (Shape shape in shapes)
            {
                shape.Draw();

            }

        }
    }
}
