using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treug2
{
    internal class Operation
    {
        // площадь треугольника по формуле Герона
        public static double CalcArea(double a, double b, double c)
        {
            if (!IsTriangleValid(a, b, c))
            {
                Console.WriteLine("A triangle with such sides cannot be made.");
                return 0;
            }

            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        }

        // перегрузка площади для равностороннего треугольника
        public static double CalcArea(double a)
        {
            return (a * a * Math.Sqrt(3)) / 4;
        }

        // условие неравенства треугольника
        private static bool IsTriangleValid(double a, double b, double c)
        {
            return (a + b > c) && (b + c > a) && (a + c > b);
        }
    }
}
