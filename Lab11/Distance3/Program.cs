namespace Distance3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Distance distance0 = new Distance();
            Distance distance1 = new Distance(1, 5.5);
            Distance distance2 = new Distance(3, 19.5);

            Distance distanceSum = distance1 + distance2;
            Distance distanceDiff = distance1 - distance2;

            Console.WriteLine("Distance 0: " + distance0);
            Console.WriteLine("Distance 1: " + distance1);
            Console.WriteLine("Distance 2: " + distance2);
            Console.WriteLine("Sum 1+2: " + distanceSum);
            Console.WriteLine("Subtraction 1-2: " + distanceDiff);

            Console.WriteLine("Compare 1<2: " + (distance1 < distance2));
            Console.WriteLine("Compare 1<=2: " + (distance1 <= distance2));
            Console.WriteLine("Compare 1>=2: " + (distance1 > distance2));
            Console.WriteLine("Compare 1>=2: " + (distance1 >= distance2));
        }
    }
}
