namespace Alg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double target = 2023;

            //double x = 1;
            //double oldx;

            //do
            //{
            //    oldx = x;
            //    x = (x + target / x) / 2;
            //}
            //while (oldx != x);

            //Console.WriteLine(x);
            //Console.WriteLine(x * x);

            double result = CalculateSquareRoot(target);

            Console.WriteLine(result);
            Console.WriteLine(result * result);
        }

        public static double CalculateSquareRoot(double target)
        {
            double x = 1;
            double oldx;

            do
            {
                oldx = x;
                x = (x + target / x) / 2;
            } while (oldx != x);

            return x;
        }
    }
}
