namespace Utils
{
    internal class Test
    {
        static void Main(string[] args)
        {
            // Get input numbers
            Console.WriteLine("Enter first number:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int y1 = int.Parse(Console.ReadLine());

            // Test the Greater( ) method
            int greater = Utils.Greater(x1, y1);
            Console.WriteLine("The greater value is " + greater);

            //Test the Swap( ) method
            Console.WriteLine("Before swap: " + x1 + "," + y1);
            Utils.Swap(ref x1, ref y1);
            Console.WriteLine("After swap: " + x1 + "," + y1);

            Console.WriteLine();

            // Test the Factorial( ) method
            int f; // result
            bool ok; // success or failure
            Console.WriteLine("Number for factorial:");
            int x2 = int.Parse(Console.ReadLine());
            ok = Utils.Factorial(x2, out f);
            if (ok)
                Console.WriteLine("Factorial(" + x2 + ") = " + f);
            else
                Console.WriteLine("Cannot compute this factorial");
        }
    }
}
