using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Func(int x, ref int y)
        {
            x += 10; y += 10;  //изменение параметров
            Console.WriteLine("In Func: {0}, {1}", x, y);
        }

        static void Main()
        {
            int a = 10, b=1 ;  // строка 1
            Console.WriteLine("In Main: {0}, {1}", a, b);
            Func(a, ref b);
            Console.WriteLine("In Main: {0}, {1}", a, b);
        }

    }
}
