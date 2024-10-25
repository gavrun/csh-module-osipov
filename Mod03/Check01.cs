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
            byte x = 200; byte y = 200;
            try
            {
                byte result = unchecked((byte)(x + y));
              // byte result = ((byte)(x + y));
                Console.WriteLine("1: {0}", result);
                result = ((byte)(x + y));
                Console.WriteLine("2: ", result);
            }
            catch (OverflowException)
            {
                Console.WriteLine("возникло переполнение");
            }

        }
    }
}
