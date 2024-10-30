using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTreug
{
    internal class Square : Shape, IRotatable
    {
        internal double side;

        internal Square(double sSide)
        {
            side = sSide;
        }

        internal void ShowSide()
        {
            Console.WriteLine($"Side of square: {side}"); // change returning a string
        }

        internal override double GetShapePerimeter()
        {
            return 4 * side;
        }
        internal override double GetShapeArea()
        {
            return Math.Pow(side, 2);
        }
        internal string[] GetShapeAll()
        {
            return new string[] { side.ToString("F2"), GetShapePerimeter().ToString("F2"), GetShapeArea().ToString("F2"), };
        }

        public void RotateShape()
        {
            Console.WriteLine("The square has been rotated around its center."); // change returning a string
        }
    }
}
