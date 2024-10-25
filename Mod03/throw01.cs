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
                if (x < 0) throw new Exception("введено недопустимое значение"); //1
                Console.WriteLine("ok");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            } 

        }
    }
}
