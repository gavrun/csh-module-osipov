﻿namespace Quadratic2
{
    internal class QuadEq
    {
        public static (int result, double? root1, double? root2) /*int*/ CalcQuadEq(out double rootX1, out double rootX2, double coefA, double coefB, double coefC)
        {
            rootX1 = 0; //default here, 'out' by reference
            rootX2 = 0;

            //discriminant
            double discriminant = coefB * coefB - 4 * coefA * coefC;

            if (discriminant > 0)
            {
                rootX1 = (-coefB + Math.Sqrt(discriminant)) / (2 * coefA);
                rootX2 = (-coefB - Math.Sqrt(discriminant)) / (2 * coefA);
                //return 1;
                return (1, rootX1, rootX2);
            }
            else if (discriminant == 0)
            {
                rootX1 = -coefB / (2 * coefA);
                rootX2 = rootX1;
                //return 0;
                return (0, rootX1, rootX2);
            }
            else
                //return -1;
                return (-1, null, null);

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //coefficients by value
            Console.WriteLine("Enter the coefficients of the quadratic equation (a, b, c).");
            Console.WriteLine("a:");
            //double a = double.Parse(Console.ReadLine());
            double cA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b:");
            double cB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c:");
            double cC = Convert.ToDouble(Console.ReadLine());

            // default variables, not by 'ref' 
            double rX1, rX2;

            //quadratic equation
            //int result = QuadEq.CalcQuadEq(out rX1, out rX2, cA, cB, cC);
            var (result, root1, root2) = QuadEq.CalcQuadEq(out rX1, out rX2, cA, cB, cC);

            // results
            if (result > 0)
            {
                Console.WriteLine($"The equation with coefficients a = {cA}, b = {cB}, c = {cC} has two distinct roots: x1 = {root1}, x2 = {root2}");
            }
            else if (result == 0)
            {
                Console.WriteLine($"The equation with coefficients a = {cA}, b = {cB}, c = {cC} has one root: x1 = x2 = {root1}");
            }
            else
            {
                Console.WriteLine($"No real roots for the equation with coefficients a = {cA}, b = {cB}, c = {cC}.");
            }

            // equation, 0 = a * Math.Pow(x, 2) + b * x + c
            // debug
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"DEBUG your equation: {cA} * (X)^2 + {cB} * (X) + {cC} = 0");
            Console.WriteLine("DEBUG other examples:\n" +
                "No real roots: a = 1, b = 2, c = 3\n" +
                "One root (double): a = 1, b = -4, c = 4 (x1 = x2 = 2)\n" +
                "Two distinct roots: a = 1, b = -5, c = 6 (x1 = 3, x2 = 2)\n" +
                "Two distinct roots: a = 2, b = -8, c = 6 (x1 = 3, x2 = 1)");
            Console.ResetColor();
        }
    }
}
