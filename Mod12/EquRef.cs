using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EquRef
{
    
    class Test
 //   struct Test
    {
        public int Num { get; set; }
        public string Str { get; set; }

        static void Main()
        {
            Test a = new Test() { Num = 1, Str = "Hi" };
            Test b = new Test() { Num = 1, Str = "Hi" };

            bool areEqual = System.Object.ReferenceEquals(a, b);
            bool areEqual2 = System.Object.Equals(a, b);
            // False:
            System.Console.WriteLine("ReferenceEquals(a, b) = {0}", areEqual);
        System.Console.WriteLine("Equals(a, b) = {0}", areEqual2);
            // Assign b to a.
            b = a;

            // Repeat calls with different results.
            areEqual = System.Object.ReferenceEquals(a, b);
            areEqual2 = System.Object.Equals(a, b);

            // True:
            System.Console.WriteLine("ReferenceEquals(a, b) = {0}", areEqual);
        System.Console.WriteLine("Equals(a, b) = {0}", areEqual2);


            string world1 = "Мир";
            string world2 = world1;//"Мир";
       areEqual = System.Object.ReferenceEquals(world1, world2);
 areEqual2 = System.Object.Equals(world1, world2);
       System.Console.WriteLine("ReferenceEquals(world1, world2) = {0}", areEqual);
       System.Console.WriteLine("Equals(world1, world2) = {0}", areEqual2);

       if (world1 == world2)
           Console.WriteLine("world1 == world2");
       else Console.WriteLine("world1 != world2");

       Console.WriteLine(a == b);
       Console.WriteLine((object)a == (object)b);

       Console.WriteLine(world1 == world2);
       Console.WriteLine((object)world1 == (object)world2);


       string aa = "hello";
       string bb = "h";
       // Append to contents of 'b'
       bb += "ello";
       Console.WriteLine(aa == bb);
       Console.WriteLine((object)aa == (object)bb);


            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
