using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treug3a
{
    internal class Triangle
    {
        // feilds, triangle sides
        private double a;
        private double b;
        private double c;

        // constructor, create triangle and check if valid sides
        public Triangle(double sideA, double sideB, double sideC)
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

        // method, sides okay triable can be made
        public bool IsValid()
        {
            return (a + b > c) && (b + c > a) && (a + c > b);
        }

        // method, calculate perimeter
        public double CalcPerimeter()
        {
            return a + b + c;
        }

        // method, calculate area
        public double CalcArea()
        {
            double p = CalcPerimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        // method, pass triangle properties 
        public string[] GetSideA()
        {
            return new string[] { a.ToString("F2") };
        }
        public string[] GetSideB()
        {
            return new string[] { b.ToString("F2") };
        }
        public string[] GetSideC()
        {
            return new string[] { c.ToString("F2") };
        }
        public string[] GetPerimeter()
        {
            double perimeter = CalcPerimeter();
            return new string[] { perimeter.ToString("F2") };
        }
        public string[] GetArea()
        {
            double area = CalcArea();
            return new string[] { area.ToString("F2") };
        }
        public string[] GetSides()
        {
            return new string[] { a.ToString("F2"), b.ToString("F2"), c.ToString("F2") };
        }
        // method, pass all triangle properties
        public string[] GetAll()
        {
            return new string[] { a.ToString("F2"), b.ToString("F2"), c.ToString("F2"), CalcArea().ToString("F2"), CalcPerimeter().ToString("F2") };
        }
    }
}
