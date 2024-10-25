using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calc_switch
{
    class Program
    {
        static void Main()
        {
            
            bool ok = true;
            Console.Write("A= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("OP= ");
            char op = char.Parse(Console.ReadLine());
            Console.Write("B= ");
            int b = int.Parse(Console.ReadLine());
            float res = 0;
            switch (op)
            {
                case '+': res = a + b; break;	//1
                case '-': res = a - b; break;
                case '*': res = a * b; break;
                case '/': 
                case ':':    
                    if (b != 0)
                    {
                        res = (float)a / b; break;
                    }
                    else 
                 ok = false; break;
            }
            //if (ok) Console.WriteLine("{0} {1} {2} = {3}", a, op, b, res);
            //else Console.WriteLine("error");

            string str = String.Format("{0} {1} {2} = {3}", a, op, b, res);

            Console.WriteLine(ok ? str : "error");
        }

    }
}
