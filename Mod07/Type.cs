using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Type_pr
{
    class Program
    {
        public int intI = 0;
        public void MyMeth()
        {
        }

        static void Main(string[] args)
        {
           // Type t = typeof(Program);
            // Альтернативная эквивалентная конструкция
            Program t1 = new Program();
            Console.WriteLine(t1.ToString()); // имя класса
            Type t = t1.GetType();
            MethodInfo[] x = t.GetMethods();
            foreach (MethodInfo m in x) 
            {
                Console.WriteLine(m.ToString());
            }
            Console.WriteLine();

            MemberInfo[] x2 = t.GetMembers();
            foreach (MemberInfo m in x2) 
            {
                Console.WriteLine(m.ToString());
            }
        }
    }
 }

