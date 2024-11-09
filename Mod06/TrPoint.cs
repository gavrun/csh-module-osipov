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
        {// здесь может более сложная логика
            x = xd;
            y = yd;
        }

        public void Mov(double xx, double yy)
        {// здесь может более сложная логика
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

        public void Mov(double xx, double yy)
        {// свое, а потом как точки скажут
            a.Mov(xx, yy); // делегирование
            b.Mov(xx, yy);
            c.Mov(xx, yy);
        }

        public override string ToString()
        {
            return String.Format("Проверим x для каждой точки {0}, {1}, {2},", a.x, b.x, c.x);
        }
    }


    class Program
    {
        static void Mov(ref Point p, int nx, int ny)
        {
            p.x += nx;
            p.y += ny; 
        }
        static void Main(string[] args)
        {
            //Point a; 
            //a.x = 1;
            //a.y = 10;
            Point a = new Point(); // значение по умолчанию - конструктор по умолчанию
         //   Point a = new Point(1, 10); // вызов конструктора автоматически
            Point b = new Point(2,20);
            Point c = new Point(16,3);
            Triangle tr1 = new Triangle(a,b,c);
            Console.WriteLine("Треугольник " + tr1.ToString());
            Console.WriteLine("Треугольник площадью {0}", tr1.Area);

            a.Mov(5, 6);
           // Mov(ref a, 5, 6);
            Triangle tr2 = new Triangle(a, b, c);
            Console.WriteLine("Треугольник площадью {0}", tr2.Area);

            tr1.Mov(5, 15);
            Console.WriteLine("Треугольник " + tr1.ToString());


        }
    }
}
