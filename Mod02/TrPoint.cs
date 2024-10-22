using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tr_Point
{
    struct Point
    {
        public double x;
        public double y;

        public Point(double xd, double yd)
        {
            x = xd;
            y = yd;
        }

        public void Mov(double xx, double yy)
        {
            x += xx;
            y += yy;
        }

    }

    class Triangle
    {
        Point a;
        Point b;
        Point c;

        double area;
        public double Area
        {
            get
            {
                return area = Math.Abs((a.x - c.x) * (b.y - c.y) - (b.x - c.x) * (a.y - c.y)) / 2; ;
            }
        }


    public Triangle (Point pa, Point pb, Point pc)
        {
            a = pa;
            b = pb;
            c = pc;
        }
    public double getArea()
        {
            return Math.Abs((a.x - c.x) * (b.y - c.y) - (b.x - c.x) * (a.y - c.y)) / 2;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 10);
            Point b = new Point(2,20);
            Point c = new Point(16,3);
            Triangle tr1 = new Triangle(a,b,c);

            Console.WriteLine("Треугольник площадью {0}", tr1.Area);

            a.Mov(5, 6);
            Triangle tr2 = new Triangle(a, b, c);
            Console.WriteLine("Треугольник площадью {0}", tr2.Area);


        }
    }
}
