using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tr_Point
{
    struct Point
    {
        /*
         Цель структур - хранение значений данных.
         Для них не может быть объявлен базовый тип
         неявно наследуются от System.ValueType
         От типа struct не могут быть унаследованы другие типы struct (неявно запечатаны)
         */
        public double x;
        public double y;

        public Point(double xd, double yd)
        {
            x = xd;
            y = yd;
        }

        // public Point (double xd, double yd)=> (x, y) = (xd, yd);

        public void Mov(double xx, double yy)
        {
            // здесь может быть сложная логика перемещения
            x += xx;
            y += yy;
        }
    }

    class Circle
    {
        Point oCenter;
        double rd;


        double area;
        public double Area // свойство
        {
            get
            {
                return area = Math.PI * rd * rd; 
            }
        }

        public Circle (Point pa, double rd)
        {
            oCenter = pa;
            this.rd = rd;
         
        }

        public double getArea() // метод
        {
            return Math.PI * rd * rd;
        }

        public void Mov(double xx, double yy)
        {
            oCenter.Mov(xx, yy);
        }

        public override string ToString()
        {
            return String.Format("Окружность в центре {0}:{1}, радиусом {2}", oCenter.x, oCenter.y, rd);
        }
   }


    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point();
           // Point a;
            Console.WriteLine("Точка А {0}:{1}", a.x, a.y);
            double rd = 15;
            Circle cir1 = new Circle(a,rd);
            Console.WriteLine(cir1.ToString());
          
            cir1.Mov(5, 6);
           // MovCircle(cir1, 5, 6);      // удар по окружности
            Console.WriteLine(cir1.ToString());
            Circle cir2 = new Circle(a, rd);
            Console.WriteLine("Окружность площадью {0:#.##}", cir2.Area);

        }

        static void MovCircle(Circle ball, double xx, double yy)
        {
            ball.Mov(xx, yy); // делегирование действий по реакции на удар 
        }
    }
}
