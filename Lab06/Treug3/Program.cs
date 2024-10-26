using System.Drawing;

namespace Treug3
{
    //internal class Operation
    //{
    //    public static double CalcArea(double a, double b, double c)
    //    {
    //        if ((a + b <= c) || (b + c <= a) || (a + c <= b)) //inverted
    //        {
    //            Console.ForegroundColor = ConsoleColor.Red;
    //            Console.WriteLine("A triangle with such sides cannot be made.");
    //            Console.ResetColor();
    //            Console.WriteLine("Examples of valid triangles:\n" +
    //                                    "Equilateral: 3, 3, 3\n" +
    //                                    "Isosceles: 5, 5, 8\n" +
    //                                    "Right-angled: 3, 4, 5\n" +
    //                                    "Scalene: 6, 7, 8");
    //            return 0;
    //        }

    //        double p = (a + b + c) / 2;
    //        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));

    //    }

    //    public static double CalcArea(double a)
    //    {
    //        return (a * a * Math.Sqrt(3)) / 4;
    //    }
    //}

    internal class Triangle
    {
        // feilds, triangle sides
        private double a;
        private double b;
        private double c;

        // constructor, create triangle and check if valid sides
        public Triangle(double sideA, double sideB, double sideC)
        {
            a = sideA;
            b = sideB;
            c = sideC;

            if (!IsValid())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A triangle with such sides cannot be made.");
                Console.ResetColor();
                throw new ArgumentException("Invalid side lengths for a triangle.");
            }
        }

        // method, sides okay triable can be made
        public bool IsValid()
        {
            return (a + b > c) && (b + c > a) && (a + c > b);
        }

        // method
        public double CalcPerimeter()
        {
            return a + b + c;
        }

        // method, 
        public double CalcArea()
        {
            double p = CalcPerimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        // method
        public void DisplaySides()
        {
            Console.WriteLine("Triangle sides:");
            Console.WriteLine($"Side A: {a:F2}");
            Console.WriteLine($"Side B: {b:F2}");
            Console.WriteLine($"Side C: {c:F2}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to calculate the area of an equilateral triangle? (y/n)");
            string isEq = Console.ReadLine();

            Console.WriteLine("Well..");

            if (isEq.ToLower() == "y")
            {
                Console.WriteLine("Enter the length of the triangle side:");
                //double a = double.Parse(Console.ReadLine());
                double side = double.Parse(Console.ReadLine());

                // create object of class
                Triangle equilateralTriangle = new Triangle(side, side, side);

                //double s = Operation.CalcArea(a);
                double area = equilateralTriangle.CalcArea();
                double perimeter = equilateralTriangle.CalcPerimeter();

                //Console.WriteLine("---------------------------");
                //Console.WriteLine("| Side    | Area    |");
                //Console.WriteLine("---------------------------");
                //Console.WriteLine("| {0:F2}    | {1:F2}    |", a, s);
                //Console.WriteLine("---------------------------");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("| Side    | Area    | Perimeter |");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("| {0:F2}    | {1:F2}    | {2:F2}      |", side, area, perimeter);
                Console.WriteLine("---------------------------------");
            }
            else
            {
                Console.WriteLine("Enter the length of the First side:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the length of the Second side:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the length of the Third side:");
                double c = double.Parse(Console.ReadLine());

                //double s = Operation.CalcArea(a, b, c);

                //if (s > 0)
                //{
                //    Console.WriteLine("---------------------------");
                //    Console.WriteLine("| Sides     | Area      |");
                //    Console.WriteLine("---------------------------");
                //    Console.WriteLine("| {0:F2}    | {1:F2}    |", a, s);
                //    Console.WriteLine("| {0:F2}    |           |", b);
                //    Console.WriteLine("| {0:F2}    |           |", c);
                //    Console.WriteLine("---------------------------");
                //}
                try
                {
                    // create object of class
                    Triangle triangle = new Triangle(a, b, c);

                    double area = triangle.CalcArea();
                    double perimeter = triangle.CalcPerimeter();

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("| Sides   | Area    | Perimeter |");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("| {0:F2}    | {1:F2}    | {2:F2}      |", a, area, perimeter);
                    Console.WriteLine("| {0:F2}    |         |           |", b);
                    Console.WriteLine("| {0:F2}    |         |           |", c);
                    Console.WriteLine("---------------------------------");
                }
                catch (Exception ex)
                {
                    // if triangle cannot be made, suggest correct examples
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Examples of valid triangles:\n" +
                                        "Equilateral: 3, 3, 3\n" +
                                        "Isosceles: 5, 5, 8\n" +
                                        "Right-angled: 3, 4, 5\n" +
                                        "Scalene: 6, 7, 8");
                    Console.ResetColor();
                    throw;
                }
            }
        }
    }
}
