namespace Distance
{
    internal struct Distance
    {
        public int Feet;
        public int Inches;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter feet for distance 1:");
            int feet1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter inches for distance 1:");
            int inches1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter feet for distance 2:");
            int feet2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter inches for distance 2:");
            int inches2 = int.Parse(Console.ReadLine());

            Distance distance1;
            distance1.Feet = feet1;
            distance1.Inches = inches1;

            Distance distance2;
            distance2.Feet = feet2;
            distance2.Inches = inches2;

            Distance distance3;
            //(int)(Z.inch / 12);
            //Z.inch % 12
            int inches3 = (distance1.Inches + distance2.Inches);
            distance3.Inches = (int)(inches3 % 12);
            distance3.Feet = (int)(distance1.Feet + distance2.Feet + (inches3 / 12));

            Console.WriteLine("Sum of distances 1 and 2 equals:");
            // 15 '- 8"
            Console.WriteLine(distance3.Feet.ToString() + "' - " + distance3.Inches.ToString() + "\"");
        }
    }
}
