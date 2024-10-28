using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metod_Overload
{
    class Program
    {
        static void Func(int x, out int y)
        {
            x += 10; y = 10;   // определение значения выходного параметра y
            Console.WriteLine("In Func: {0}, {1}", x, y);
        }

        //static void Func(int x, ref int y)
        //{
        //    x += 10; y += 10;  //изменение параметров
        //    Console.WriteLine("In Func: {0}, {1}", x, y);
        //}

        static void Func(int x, int y)
        {
            x += 10;	// изменили значение параметра 
            y -= 10;
            Console.WriteLine("In Func:{0}, {1}", x, y);
        }

        static void Main()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("In Main:  {0}, {1}", a, b);
            Func(a, b);
            Console.WriteLine("In Main: {0}, {1}", a, b);

            int a1 = 10, b1;
            Console.WriteLine("In Main: {0}", a1);
            Func(a1, out b1);
            Console.WriteLine("In Main: {0}, {1}", a1, b1);

            //int a2 = 10, b2 = 1;  // строка 1
            //Console.WriteLine("In Main: {0}, {1}", a2, b2);
            //Func(a2, ref b2);
            //Console.WriteLine("In Main: {0}, {1}", a2, b2);
        }
    }
}
