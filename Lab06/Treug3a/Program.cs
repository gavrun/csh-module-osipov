namespace Treug3a
{
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

        // method, calculate perimeter
        public double CalcPerimeter()
        {
            return a + b + c;
        }

        // method, calculate area
        public double CalcArea()
        {
            double p = CalcPerimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        // method, pass triangle sides as string
        public string GetSides()
        {
            return $"Triangle sides:\nSide A: {a:F2}\nSide B: {b:F2}\nSide C: {c:F2}\n";
        }

        // method,
        public string GetArea()
        {
            double area = CalcArea();
            double perimeter = CalcPerimeter();
            return $"Sides:\nSide A: {a:F2}, Side B: {b:F2}, Side C: {c:F2}\n" + 
                   $"Area: {area:F2}\nPerimeter: {perimeter:F2}\n";
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
                double side = double.Parse(Console.ReadLine());

                // create object of class
                Triangle equilateralTriangle = new Triangle(side, side, side);

                //double area = equilateralTriangle.CalcArea();
                //double perimeter = equilateralTriangle.CalcPerimeter();

                //Console.WriteLine("---------------------------------");
                //Console.WriteLine("| Side    | Area    | Perimeter |");
                //Console.WriteLine("---------------------------------");
                //Console.WriteLine("| {0:F2}    | {1:F2}    | {2:F2}      |", side, area, perimeter);
                //Console.WriteLine("---------------------------------");

                Console.WriteLine(equilateralTriangle.GetSides());
                Console.WriteLine(equilateralTriangle.GetArea());
            }
            else
            {
                Console.WriteLine("Enter the length of the First side:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the length of the Second side:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the length of the Third side:");
                double c = double.Parse(Console.ReadLine());

                try
                {
                    // create object of class
                    Triangle triangle = new Triangle(a, b, c);

                    //double area = triangle.CalcArea();
                    //double perimeter = triangle.CalcPerimeter();

                    //Console.WriteLine("---------------------------------");
                    //Console.WriteLine("| Sides   | Area    | Perimeter |");
                    //Console.WriteLine("---------------------------------");
                    //Console.WriteLine("| {0:F2}    | {1:F2}    | {2:F2}      |", a, area, perimeter);
                    //Console.WriteLine("| {0:F2}    |         |           |", b);
                    //Console.WriteLine("| {0:F2}    |         |           |", c);
                    //Console.WriteLine("---------------------------------");

                    Console.WriteLine(triangle.GetSides());
                    Console.WriteLine(triangle.GetArea());
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
