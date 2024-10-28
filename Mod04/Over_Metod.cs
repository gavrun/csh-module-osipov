using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int max(int a)	//первая версия метода max
        {
            int b = 0;
            while (a > 0)
            {
                if (a % 10 > b) b = a % 10;
                a /= 10;
            }
            return b;
        }
        static int max(int a, int b) //вторая версия метода max
        {
            if (a > b) return a;
            else return b;
        }

        static int max(int a, ref int  b) //вторая версия метода max
        {
            if (a > b) return a;
            else return b;
        }

        static int max(int a, int b, int c) //третья версия метода max
        {
            if (a > b && a > c) return a;
            else if (b > c) return b;
            else return c;
        }
        static void Main()
        {
            int a = 1283, b = 45, c = 35740;
            Console.WriteLine(max(a));
            Console.WriteLine(max(a, b));
            Console.WriteLine(max(a, ref b));
            Console.WriteLine(max(a, b, c));
        }


    }
}
