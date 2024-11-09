using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tr_Point
{
    class Point
    {   // отличие приватного set от поля только для чтения (get)
        public double X { get; private set; }

        public double Y { get; }

        public Point(double xd, double yd)
        {
            X = xd;
            Y = yd;
        }

        public void Mov()
        {
            X++;
           // Y++;        // Ошибка CS0200  Невозможно присвоить значение свойству "Point.Y" — доступ только для чтения.	
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
            get => area = Math.Abs((a.X - c.X) * (b.Y - c.Y) - (b.X - c.X) * (a.Y - c.Y)) / 2; 
        }


        public Triangle (Point pa, Point pb, Point pc)
        {
                a = pa;
                b = pb;
                c = pc;
                //pa.X = 100;    // меняем поле параметра - Ошибка CS0272  Свойство "Point.X" невозможно использовать в данном контексте, так как метод доступа set недоступен.	
                //pa.Y = 100;   // меняем поле параметра - Ошибка CS0200  Невозможно присвоить значение свойству "Point.Y" — доступ только для чтения.
                pa.Mov();       // а вот здесь хначение поля параметра изменить можно!
        }
    public double getArea() => Math.Abs((a.X - c.X) * (b.Y - c.Y) - (b.X - c.X) * (a.Y - c.Y)) / 2; // метод
    }


    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 10);
            Point b = new Point(2,20);
            Point c = new Point(16,3);
            Triangle tr1 = new Triangle(a,b,c);

            double s = tr1.getArea();    // вызов метода()
            Console.WriteLine("Треугольник площадью {0}", tr1.Area); // обращение к свойству!
            Console.WriteLine(a.X);     // проверяем изменилось ли поле параметра
            Console.WriteLine(a.Y);     // проверяем изменилось ли поле параметра
        }
    }
}
