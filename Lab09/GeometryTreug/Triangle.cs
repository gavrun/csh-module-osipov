using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTreug
{
    internal class Triangle : Shape, IRotatable
    {
        // feilds, triangle sides
        private double a;
        private double b;
        private double c;

        // constructor, create triangle and check if valid sides
        internal Triangle(double sideA, double sideB, double sideC) // 'this' becomes my default constructor
        {
            a = sideA;
            b = sideB;
            c = sideC;

            if (!IsValid())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A triangle with such sides cannot be made.");
                Console.ResetColor();
                throw new ArgumentException("Invalid side lengths for a triangle.");
            }
        }

        // constructor, create equilateral triangle
        internal Triangle(double side) : this(side, side, side)
        {
            ; // overloading constructor with 'this'
        }

        // method, sides okay triable can be made
        internal bool IsValid()
        {
            return (a + b > c) && (b + c > a) && (a + c > b);
        }

        // method, calculate perimeter
        internal double CalcPerimeter()
        {
            return a + b + c;
        }

        // new method here!!
        internal override double GetShapePerimeter()
        {
            return a + b + c;
        }

        // method, calculate area
        internal double CalcArea()
        {
            double p = CalcPerimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        // new method here!!
        internal override double GetShapeArea()
        {
            double p = GetShapePerimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        // new method here!!
        public void RotateShape()
        {
            Console.WriteLine("The triangle has been rotated around its center.");
        }

        // method, pass triangle properties 
        internal string[] GetSideA()
        {
            return new string[] { a.ToString("F2") };
        }
        internal string[] GetSideB()
        {
            return new string[] { b.ToString("F2") };
        }
        internal string[] GetSideC()
        {
            return new string[] { c.ToString("F2") };
        }
        internal string[] GetPerimeter()
        {
            double perimeter = CalcPerimeter();
            return new string[] { perimeter.ToString("F2") };
        }
        internal string[] GetArea()
        {
            double area = CalcArea();
            return new string[] { area.ToString("F2") };
        }
        internal string[] GetSides()
        {
            return new string[] { a.ToString("F2"), b.ToString("F2"), c.ToString("F2") };
        }
        // method, pass all triangle properties
        internal string[] GetAll()
        {
            return new string[] { a.ToString("F2"), b.ToString("F2"), c.ToString("F2"), CalcArea().ToString("F2"), CalcPerimeter().ToString("F2") };
        }

        // new method here!! (indented)
        internal string[] GetShapeAll() 
        {
            return new string[]
            {
                a.ToString("F2"),
                b.ToString("F2"),
                c.ToString("F2"),
                GetShapeArea().ToString("F2"),
                GetShapePerimeter().ToString("F2")
            };
        }
    }
}