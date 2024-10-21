namespace Shooting2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RELEASE Welcome to a shooting range!");

            Weapon crossbow = new Weapon(3);

            Console.WriteLine($"RELEASE You have {crossbow.NumShots} shots.");

            Range range = new Range();

            Target target = new Target();

            for (int i = 0; i < crossbow.initialShots; i++)
            {
                Console.WriteLine("RELEASE Fire at will..");
                crossbow.Shoot();

                target.ApplyWind(0.5);

                int score = target.RegisterHit(crossbow);
                range.AddScore(score);
                Console.WriteLine($"DEBUG shots left {crossbow.NumShots}");

                if (i < crossbow.NumShots - 1)
                {
                    Console.WriteLine("RELEASE One more shot..");
                }
            }

            range.PrintTotalScore();
        }
    }
}
