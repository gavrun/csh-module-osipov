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
            Console.WriteLine("Using doubles:");
            double a = 0.1;
            double b = 0.2;
            if (a + b == 0.3) // Никогда не сравнивайте числа двойной точности с плавающей запятой с помощью оператора ==.
            {
               // Console.WriteLine($"{a} + {b} equals 0.3");
                Console.WriteLine("{0} + {1} equals {2}", a,b,0.3);
            }
            else
            {
             //   Console.WriteLine($"{a} + {b} does NOT equal 0.3");
                Console.WriteLine("{0} + {1} does not equals {2}", a,b,0.3);
            }

            Console.WriteLine("Using decimals:");
            decimal c = 0.1M; // удалите М и посмотрите что произойдет
            decimal d = 0.2M;
            if (c + d == 0.3M) // Никогда не сравнивайте числа двойной точности с плавающей запятой с помощью оператора ==.
            {
                // Console.WriteLine($"{c} + {d} equals 0.3");
                Console.WriteLine("{0} + {1} equals {2}", c, d, 0.3);
            }
            else
            {
                //   Console.WriteLine($"{c} + {d} does NOT equal 0.3");
                Console.WriteLine("{0} + {1} does not equals {2}", c, d, 0.3);
            }

            Console.WriteLine(sizeof(double)); // 8
            Console.WriteLine(sizeof(decimal)); // 16


        }
    }
}
