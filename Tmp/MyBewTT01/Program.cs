using System;
using MyBewTT01;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05Ex04
{

    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1;            
            f1.m_numerator = 3;
            f1.m_denominator = 5;
            Console.WriteLine(f1);
            Fraction f2 = new Fraction(1, 2);      // вызывается конструктор с параметрами
            Console.WriteLine(f2);
            Fraction f3;
            f3.m_denominator = f1.m_denominator + f2.m_denominator;

            string[] friendNames =
            {
                "Robert Barwell",
                "Mike Parry",
                "Jeremy Beacock"
            };

            // Контейнер стек был создан в отдельной сборке ClassLibraryDemo (см. ссылки)
            ClassLibraryDemo.Stack myStack = new ClassLibraryDemo.Stack();
            myStack.Push(friendNames[0]);

            int i;
            Console.WriteLine("Here are {0} of my friends:", friendNames.Length);
            for (i = 0; i < friendNames.Length; i++)
            {
                Console.WriteLine(friendNames[i]);
            }
            foreach (var friendName in friendNames)
            {
                Console.WriteLine(friendName);
            }

            Console.WriteLine("From stack: {0}", myStack.Pop());
            Console.ReadKey();
        }
    }
}
