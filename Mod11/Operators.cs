using System;
using System.Collections.Generic;
using System.Text;

namespace operations
{
	// ƒл€ моделировани€ унарных постфиксных и префиксных операций может
	// потребоватьс€ модификаци€ структуры класса: объ€вл€ютс€ дополнительные
	// переменные дл€ сохранени€ значений координат.

	public class Point2D
	{
		public double x,    y;
		double xTmp, yTmp;

		public Point2D()
		{
			x    = 0;
			y    = 0;
			xTmp = 0;
			yTmp = 0;
		}

        public Point2D(Point2D p)
        {
            x = p.x;
            y = p.y;
        }



        public static Point2D operator +(Point2D p1, double num)
        {
            p1.x = p1.x + num;
            p1.y = p1.y + num;
            return p1;
        }

		public static Point2D operator ++(Point2D par)
		{ 
			// ‘актическим координатам присваиваютс€ старые значени€.
            par.x = (par.xTmp)++;
            par.y = (par.yTmp)++;
            return par;
		}

		public static Point2D operator --(Point2D par)
		{
			// ‘актическим координатам присваиваютс€ новые значени€.
			par.x = --(par.xTmp);
			par.y = --(par.yTmp);

			return par;
		}

        public override string ToString()
        {
            return String.Format("{0:F3},{1:F3}", x, y);
        }

	}

	class Program
	{
		static void Main(string[] args)
		{
			Point2D p = new Point2D();
			int i;

			// ѕри этом в соответствии с объ€влением,
			// унарный плюс всегда постфиксный,
			// а унарный минус всегда префиксный. 

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(p++);
            }
            Console.WriteLine("============================================");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(++p);
            }
            Console.WriteLine("============================================");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(p--);
            }
            Console.WriteLine("============================================");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(--p);
                Console.ReadLine();

            }
		}
	}
}