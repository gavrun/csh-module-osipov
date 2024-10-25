using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = Convert.ToChar('a' | 'b' | 'c');
            switch (ch)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("case A| case a");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("case B| case b");
                    break;
                case 'C':
                case 'c':
                case 'D':
                case 'd':
                    Console.WriteLine("case D| case d");
                    break;

                default:
                    break;
            }
        }
    }
}
