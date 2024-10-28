using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Func(int x)
        {
            x += 10;	// изменили значение параметра 
            Console.WriteLine("In Func: " + x);
        }
        static void Main()
        {
            int a = 10;
            Console.WriteLine("In Main: " + a);
            Func(a);
            Console.WriteLine("In Main: " + a);
        }

    }
}
