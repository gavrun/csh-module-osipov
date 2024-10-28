using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("You sent the Swap() method a {0}",
              typeof(T));
            T temp;
            temp = a;
            a = b;
            b = temp;
        }



        static void Main()
        {
            // Swap 2 ints.
            int a = 10, b = 90;
            Console.WriteLine("Before swap: {0}, {1}", a, b);

            Swap<int>(ref a, ref b);

            Console.WriteLine("After swap: {0}, {1}", a, b);
            Console.WriteLine();

            // Swap 2 strings.
            string s1 = "Hello", s2 = "There";
            Console.WriteLine("Before swap: {0} {1}!", s1, s2);

            Swap<string>(ref s1, ref s2);

            Console.WriteLine("After swap: {0} {1}!", s1, s2);
            Console.WriteLine();

            // System.Boolean.
            bool b1 = true, b2 = false;
            Console.WriteLine("Before swap: {0}, {1}", b1, b2);

            Swap(ref b1, ref b2);   // Выведение параметра типа

            Console.WriteLine("After swap: {0}, {1}", b1, b2);
            Console.WriteLine();
        }

    }
}
