using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3, y = 7;
            int? x1 = null, y1, z1;
            y1 = x + y;
            z1 = x1 ?? y1;
                y = x1 ?? -1;
            Console.WriteLine("x1 = {0}, y1 = {1}, z1 = {2}", x1, y1, z1);
            Console.WriteLine("y = " + y);

            //x = (int)x1;
            y = (int)y1;
            Console.WriteLine("x = {0}, y = {1}", x, y);
            z1 = x1 * y ?? y1;
            y1 = z1 - y1;
            Console.WriteLine("x1 = {0}, y1 = {1}, z1 = {2}", x1, y1, z1);

            System.Nullable<double> u = x + x1;
            double? v = y + y1, w;
            w = u ?? v + y1;
            Console.WriteLine("u = {0}, v = {1}, w = {2}", u, v, w);

        }
    }
}
