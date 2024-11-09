using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor_static
{
    public class Bus
    {
        static int a = 20;
        static int b = 10;

        // Static constructor:
        static Bus()
        {
            System.Console.WriteLine("The static constructor invoked.");
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
        }

        public static void Drive()
        {
            System.Console.WriteLine("The Drive method invoked.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
         //   Bus bs = new Bus();
         //    Bus ds = new Bus();
         Bus.Drive();
        }
    }
}
