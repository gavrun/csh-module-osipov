using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnDel
{
    class TestClass
    {
        delegate void Printer(string s);

        static void Main(string[] args)
        {
            Printer p = delegate(string j)
            {
                System.Console.WriteLine(j);
            };

        // Results from the anonymous delegate call:
        p("The delegate using the anonymous method is called.");

        // The delegate instantiation using a named method "DoWork":
        p = new Printer(TestClass.DoWork);

        // Results from the old style delegate call:
        p("The delegate using the named method is called.");
        p("Repeat The delegate using the named method is called.");
    }

        // The method associated with the named delegate:
        static void DoWork(string k)
        {
            System.Console.WriteLine(k);
        }
       
    }
}
