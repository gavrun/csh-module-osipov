namespace Divider2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the first integer");
                int i = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the second integer");
                int j = Int32.Parse(Console.ReadLine());

                int k = i / j;
                Console.WriteLine($"The result of dividing {i} by {j} is {k}");

                int m = i * j;
                Console.WriteLine($"The result of multiplying {i} by {j} is {m}");
            }
            catch (FormatException lapse)
            {
                Console.WriteLine("An exception was thrown: {0}", lapse.Message);
                throw;
            }
            catch (Exception oops)
            {
                Console.WriteLine("An exception was thrown: {0}", oops.Message);
                throw;
            }
        }
    }
}
