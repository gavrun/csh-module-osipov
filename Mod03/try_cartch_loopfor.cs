using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TryCath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; ++i)
            {
                try
                {
                    Console.WriteLine("y({0})={1}", i, 100 / (i * i - 9));
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("y({0})=Деление на 0", i);
                }
            }
        }

    }
}
