namespace Divider
{
    internal class DivideIt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first integer");
            //string temp = Console.ReadLine();
            int i = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second integer");
            //temp = Console.ReadLine();
            int j = Int32.Parse(Console.ReadLine());

            int k = i / j;
            //Console.WriteLine("The result of dividing {0} by {1} is {2}", i, j, k);
            Console.WriteLine($"The result of dividing {i} by {j} is {k}");

            int m = i * j;
            Console.WriteLine($"The result of multiplying {i} by {j} is {m}");
        }
    }
}
