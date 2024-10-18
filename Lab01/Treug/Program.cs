using System.Drawing;
using System.Xml;

namespace Treug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            //perimeter P treugolnica
            Console.WriteLine("Please enter perimeter treug:");
            double P = Int32.Parse(Console.ReadLine());

            //poluperimeter p treugolnica
            double p = P / 2;
            //storona A treugolnica
            double a = P / 3;

            //ploschad S treugolnica
            double s = Math.Sqrt(p * (p - a) * (p - a) * (p - a));
            double s1 = (a * a * Math.Sqrt(3)) / 4;

            //Console.WriteLine(“Fixed - point formatting – { 0:F3}”, 888.8888);
            //Console.WriteLine("{0:F2}", s);

            //nebolshaya tablitsa
            Console.WriteLine("---------------------------");
            Console.WriteLine("| storona    | ploshad    |");
            Console.WriteLine("---------------------------");
            Console.WriteLine("| {0:F2}    | {1:F2}    |", a, s);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Bye");
        }
    }
}
