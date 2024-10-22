using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operation_a
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
              int a = 2000000000, b = 999999999;
              short i = 32760, j = 15;
         //   double a = 14.2, b = 3.5;
            short s;
            s = (short)(i + j);
            int c = a + b;
             Console.WriteLine("{0} ", c);
            }
            

     //       Console.WriteLine("{0} {1} {2} {3}", s, i * j, i / j, i % j);
     //       Console.WriteLine("{0} {1} {2}", a * b, a / b, a % b);

        }
    }
}
