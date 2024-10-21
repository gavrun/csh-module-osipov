namespace Quadratic
{
    internal class QuadEq
    {
        public static int CalcQuadEq(out double rootX1, out double rootX2, double coefA = 0, double coefB = 0, double coefC = 0)
        {
            rootX1 = 0; //default here, 'out' by reference
            rootX2 = 0;

            //discriminant
            double discriminant = coefB * coefB - 4 * coefA * coefC;

            if (discriminant > 0)
            {
                rootX1 = (-coefB + Math.Sqrt(discriminant)) / (2 * coefA);
                rootX2 = (-coefB - Math.Sqrt(discriminant)) / (2 * coefA);
                return 1;
            } else if (discriminant == 0)
            {
                rootX1 = -coefB / (2 * coefA);
                rootX2 = rootX1;
                return 0;
            } else 
                return -1;

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
            int result = QuadEq.CalcQuadEq(out rX1, out rX2, cA, cB, cC);

            // equation, 0 = a * Math.Pow(x, 2) + b * x + c
            // debug
            Console.WriteLine($"DEBUG equation: {cA} * (X)^2, 2) + {cB} * (X) + {cC} = 0 .");

            // results
            if (result > 0)
            {
                Console.WriteLine($"The equation with coefficients a = {cA}, b = {cB}, c = {cC} has two distinct roots: x1 = {rX1}, x2 = {rX2}");
            } else if (result == 0)
            {
                Console.WriteLine($"The equation with coefficients a = {cA}, b = {cB}, c = {cC} has one root: x1 = x2 = {rX1}");
            } else
            {
                Console.WriteLine($"No real roots for the equation with coefficients a = {cA}, b = {cB}, c = {cC}.");
            }
        }
    }
}
