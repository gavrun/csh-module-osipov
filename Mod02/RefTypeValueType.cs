using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rs
{
   // class Numbers
    struct Numbers
    {
        public int val;

        public Numbers(int _val)
        { 
            val = _val; 
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Numbers n1 = new Numbers(0); 
            Numbers n2 = n1; 
            n1.val += 1; 
            n2.val += 2;
            Console.WriteLine("n1 = {0}, n2 = {1}", n1, n2);

        }
    }
}
