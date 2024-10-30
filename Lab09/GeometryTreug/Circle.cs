using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTreug
{
    internal class Circle : Shape
    {
        internal double radius;

        internal Circle(double cRadius)
        {
            radius = cRadius;
        }

        internal void ShowRadius()
        {
            Console.WriteLine($"Radius of circle: {radius}"); // change returning string
        }

        internal override double GetShapePerimeter()
        {
            return 2 * Math.PI * radius; // math class, Pi number
        }
        internal override double GetShapeArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        internal string[] GetShapeAll()
        {
            return new string[] { radius.ToString("F2"), GetShapePerimeter().ToString("F2"), GetShapeArea().ToString("F2"), };
        }
    }
}