﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ObjectTest
    {
        public int i = 10;
    }

    class MainClass2
    {
        static void Main()
        {
            object a;
            a = 1;   // an example of boxing
            Console.WriteLine(a);
            Console.WriteLine(a.GetType());
            Console.WriteLine(a.ToString());

            a = new ObjectTest();
            ObjectTest classRef;
            classRef = (ObjectTest)a;
            Console.WriteLine(classRef.i);
        }
    }

}
