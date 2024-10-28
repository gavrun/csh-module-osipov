using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Func(int x, out int y)
        {
            x += 10; y = 10;   // определение значения выходного параметра y
            Console.WriteLine("In Func: {0}, {1}", x, y);
        }

        static void Main()
        {
            int a = 10, b;
            Console.WriteLine("In Main: {0}", a);
            Func(a, out b);
            Console.WriteLine("In Main: {0}, {1}", a, b);
			
			//C#7
			Func(a, out int bb); // передавать без объявления заранее
			Сonsole.WriteLine($"In Main: {a}, {b}");
			
			// Discarding out Parameters
			Func(a, out _); 
			Сonsole.WriteLine($"In Main: {a}");
			
        }

    }
}
