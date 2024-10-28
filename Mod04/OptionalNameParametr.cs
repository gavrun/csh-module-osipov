using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int Func(int x, int y)	// описание метода - формальные параметры
        {
            return (x > y) ? x : y;
        }

        static double expN(double x, int e = 2) // с одним необязательным параметром
        {
            double result = 1;
            for (int i = 0; i < e; i++)
            result *= x;
            return result;
        }

        // Ошибка! Стандартное значение для необязательного аргумента
        // должно быть известно во время компиляции!
        //static void EnterLogData(string message, DateTime timeStamp = DateTime.Now)
        //{

        //}


        static void Main()
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());

            int max = Func(Func(a, b), c);	// вызовы метода Func, в метод передаются фактические параметры
            Console.WriteLine("Максимальное значение чисел {0}, {1}, и {2} равно {3}", a, b, c, max);

            double m1 = expN(a);	// в метод передается один параметр
            Console.WriteLine("Квадрат числа {0} равен {1}", a, m1);

            double m2 = expN(a, b);	// в метод передается два параметра
            Console.WriteLine("Число {0} в степени {1} равно {2}", a, b, m2);

            double m3 = expN(a, e:3);	// в метод передается именованный параметра
            Console.WriteLine("Число {0} в степени {1} равно {2}", a, 3, m3);
        }

    }
}
