using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treug2a
{
    internal class Operation
    {
        // площадь треугольника по формуле Герона
        public static double CalcArea(double a, double b, double c)
        {
            if ((a + b <= c) || (b + c <= a) || (a + c <= b)) //inverted
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A triangle with such sides cannot be made.");
                Console.ResetColor();
                Console.WriteLine("Examples of valid triangles:\n" +
                                        "Equilateral: 3, 3, 3\n" +
                                        "Isosceles: 5, 5, 8\n" +
                                        "Right-angled: 3, 4, 5\n" +
                                        "Scalene: 6, 7, 8");
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

        // условие неравенства треугольника ERR
        //private static bool IsTriangleValid(double a, double b, double c)
        //{
        //    return (a + b > c) && (b + c > a) && (a + c > b);
        //}
    }
}
