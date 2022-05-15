using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPart2
{
    internal class Shape
    {
        public int x { get; set; }
        public int y { get; set; }
        public virtual void Draw()
        {
            Console.WriteLine("Drowing Shape");
        }
    }


    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }


    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Triangle");
        }
    }

}
