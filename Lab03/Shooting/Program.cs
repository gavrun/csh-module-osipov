namespace Shooting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a shooting range!");

            int totalScore = 0;

            // target template, radii of circles
            double R1 = 1;
            double R2 = 2;
            double R3 = 3;

            int numShots = 3;
            Console.WriteLine("You have {0} shots.", numShots);

            for (int i = 0; i < numShots; i++)
            {
                // shot coordinates X and Y
                Console.WriteLine("Aim X");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Aim Y");
                double y = double.Parse(Console.ReadLine());

                double distance = Math.Sqrt(x * x + y * y);

                // hit target area by radius
                if (distance <= R1)
                {
                    Console.WriteLine("Bulls eye!");
                    totalScore += 10;
                }
                else if (distance <= R2)
                {
                    Console.WriteLine("Good.");
                    totalScore += 5;
                }
                else if (distance <= R3)
                {
                    Console.WriteLine("Not bad.");
                    totalScore += 1;
                }
                else
                {
                    Console.WriteLine("Miss!");
                    totalScore += 0;
                }

                // hit hatched area
                if (x >= -3 && x <= 3 && y >= 0 && y <= 3)
                {
                    Console.WriteLine("IN");
                }
                else if (x == -3 || x == 3 || y == 0 || y == 3)
                {
                    Console.WriteLine("AT");
                }
                else
                {
                    Console.WriteLine("OUT");
                }

                if (i < numShots - 1)
                {
                    Console.WriteLine("One more shot..");
                }
            }

            Console.WriteLine("Easy, cowboy!");
            // total score
            Console.WriteLine("Total: {0}. You're out.", totalScore);
        }
    }
}
