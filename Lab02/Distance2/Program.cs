namespace Distance2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input data

            Console.WriteLine("Enter feet for distance 1:");
            int feet1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter inches for distance 1:");
            int inches1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter feet for distance 2:");
            int feet2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter inches for distance 2:");
            int inches2 = int.Parse(Console.ReadLine());

            // create instances

            Distance2 distance1 = new Distance2(feet1, inches1);
            Distance2 distance2 = new Distance2(feet2, inches2);

            // calc a sum

            Distance2 sum = Distance2.AddDistances(distance1, distance2);

            // output data

            Console.WriteLine("Sum of distances 1 and 2 equals:");
            Console.WriteLine(sum.ToString());

        }
    }
}
