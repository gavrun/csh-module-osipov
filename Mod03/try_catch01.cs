using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = int.Parse(Console.ReadLine());
                int y = 1 / x;
                Console.WriteLine("y={0}", y);
                Console.WriteLine("блок try выполнился успешно");
            }
            catch		// *
            {
                Console.WriteLine("возникла какая-то ошибка");
            }
            Console.WriteLine("конец программы");

        }
    }
}
