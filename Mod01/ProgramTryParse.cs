using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kvadro
{

    class Program
    {
        static void Main(string[] args)
        {
            double s;
            Console.Write("s = ");
            //double s = double.Parse(Console.ReadLine());
            bool sb = double.TryParse(Console.ReadLine(), out s);
            double p = 4 * Math.Sqrt(s);
            if (sb)
                Console.WriteLine("p = " + p);
            else
                Console.WriteLine("Подсчет не выполнен, ошибка при вводе");

        }
    }
}
