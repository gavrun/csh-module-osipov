namespace Treug2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //периметр P треугольника
            //Console.WriteLine("Please enter perimeter treug:");
            //double P = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Do you want to calculate the area of ​​an equilateral triangle? (y/n)");
            string isEq = Console.ReadLine();

            Console.WriteLine("Well..");

            if (isEq.ToLower() == "y")
            {
                Console.WriteLine("Enter the length of the triangle side:");
                double a = double.Parse(Console.ReadLine());

                double s = Operation.CalcArea(a);

                //полупериметр p треугольника
                //double p = P / 2;

                //сторона A треугольника
                //double a = P / 3;

                //площадь S треугольника
                //double s = Math.Sqrt(p * (p - a) * (p - a) * (p - a));
                //double s1 = (a * a * Math.Sqrt(3)) / 4;

                //небольшая таблица
                Console.WriteLine("---------------------------");
                Console.WriteLine("| Side    | Area    |");
                Console.WriteLine("---------------------------");
                Console.WriteLine("| {0:F2}    | {1:F2}    |", a, s);
                Console.WriteLine("---------------------------");

            } else
            {
                Console.WriteLine("Enter the length of the First side:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the length of the Second side:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the length of the Third side:");
                double c = double.Parse(Console.ReadLine());

                double s = Operation.CalcArea(a, b, c);

                if (s > 0)
                {
                    // еще одна небольшая таблица
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("| Sides     | Area      |");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("| {0:F2}    | {1:F2}    |", a, s);
                    Console.WriteLine("| {0:F2}    |           |", b);
                    Console.WriteLine("| {0:F2}    |           |", c);
                    Console.WriteLine("---------------------------");
                }
            }
        }
    }
}
