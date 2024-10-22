using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Preobr
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = -4; // 1000...000100 -> 111111111... 011 ->  11111111||11...100
            byte j = 4;
            int a = (int)j;  //преобразование без потери точности
            byte b = (byte)i; //преобразование с потерей точности
            Console.WriteLine("{0} {1}", a, b);

            byte a1 = 9;
            byte b1 = 5;
            byte c1;
            c1 = (byte)(a1 + b1);
            Console.WriteLine("c1 = "+ c1);
            var c11 = a1 + b1;
            Console.WriteLine("c11 = " + c11);

            int a2 = 2000000000;
            int b2 = 999999999;
            int c2;
            c2 = a2 + b2;
            Console.WriteLine("c2 = " + c2);
            Console.ReadLine();

            var s1 = 1 + 2 + "A";
            Console.WriteLine("1 + 2 + A = " + s1);
            var s2 = 1 + "A" + 2;
            Console.WriteLine("1 + A + 2 = " + s2);
            var s3 = "A" + 1 + 2;
            Console.WriteLine("A + 1 + 2 = " + s3);

            Console.ReadLine();

            var s11 = 1 + 2 + 'A';
            Console.WriteLine("1 + 2 + A = " + s11);
            var s22 = 1 + 'A' + 2;
            Console.WriteLine("1 + A + 2 = " + s22);
            var s33 = 'A' + 1 + 2;
            Console.WriteLine("A + 1 + 2 = " + s33); 

        }
    }
}
