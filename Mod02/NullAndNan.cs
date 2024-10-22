using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullAndNan
{
    class Program
    {
        static void Main(string[] args)
        {
            double? u = null, v = 0, w = 1.5;
            Console.WriteLine("u = {0}, v = {1}, w = {2}",u, v, w);

            double? x, y, z;
            x = u + v; y = w / v; z = x + y;
            Console.WriteLine("x = u + v = {0}, y = w / v = {1}, " + " z = x + y = {2}", x, y, z);

            x = -y; y = v * y; z = x + y;
            Console.WriteLine("x = -y = {0}, y = v * y = {1}, " + " z = x + y = {2}", x, y, z);

            double p = -(double)w, q = double.NegativeInfinity;
            Console.WriteLine("p = {0}, q = {1}, 1 / q = {2}", Math.Sqrt(p), q, 1 / q);
            p = 1e160;
            Console.WriteLine("p = {0}, p * p = {1}", p, p * p);
            float p1 = 1e20f;
            Console.WriteLine("p1 = {0}, p1 * p1 = {1}", p1, p1 * p1);

        }
    }
}
