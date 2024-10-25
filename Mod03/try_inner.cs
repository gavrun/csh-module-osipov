using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");    //a = 1
            byte a = byte.Parse(Console.ReadLine());
            Console.WriteLine("b=");    //b = 15
            byte b = byte.Parse(Console.ReadLine());
            int f = 1;
            try //Внешний блок-try
            {
                for (byte i = a; i <= b; ++i)
                {
                    try //Внутренний блок-try
                    {
                        f = checked((int)(f * i));
                        Console.WriteLine("y({0})={1:f6}", i, 100 / (f - 1));
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("y({0})=Деление на 0", i);
                    }
                }
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("ERROR");
            }

        }
    }
}
