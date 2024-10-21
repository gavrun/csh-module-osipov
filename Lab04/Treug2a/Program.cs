namespace Treug2a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to calculate the area of ​​an equilateral triangle? (y/n)");
            string isEq = Console.ReadLine();

            Console.WriteLine("Well..");

            if (isEq.ToLower() == "y")
            {
                Console.WriteLine("Enter the length of the triangle side:");
                double a = double.Parse(Console.ReadLine());

                double s = Operation.CalcArea(a);

                //небольшая таблица
                Console.WriteLine("---------------------------");
                Console.WriteLine("| Side    | Area    |");
                Console.WriteLine("---------------------------");
                Console.WriteLine("| {0:F2}    | {1:F2}    |", a, s);
                Console.WriteLine("---------------------------");

            }
            else
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
