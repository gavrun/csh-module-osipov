using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // метод To string
            Person p = new Person("Михаил", "Иванов");
            Console.WriteLine(p.ToString());

            Object o = p;
            Console.WriteLine(o.ToString());

            Person pp = new Person(p);

            // сравнение объектов
            Console.WriteLine("");
            Console.WriteLine("Сравнение классов:");

            Person p1 = new Person("Михаил", "Иванов");
            Person p2 = new Person("Михаил", "Иванов");
            Person p3 = p1;
            Person p4 = new Person("Михаил", "Смирнов");
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p3));
            Console.WriteLine(p1.Equals(p4));
            Console.WriteLine(p1.Equals(pp));

            // сравнение объектов
            Console.WriteLine("");
            Console.WriteLine("Сравнение объектов 2:");
            Console.WriteLine(ComparePersons(p1, p2));
            Console.WriteLine(ComparePersons(p1, p3));
            Console.WriteLine(ComparePersons(p1, p4));
            Console.WriteLine(ComparePersons(p1, pp));

            // сравнение объектов
            Console.WriteLine("");
            Console.WriteLine("Сравнение объектов 3:");
            Console.WriteLine(p1.ComparePersons(p2));
            Console.WriteLine(p1.ComparePersons(p3));
            Console.WriteLine(p1.ComparePersons(p4));
            Console.WriteLine(p1.ComparePersons(pp));

            Console.ReadLine();
        }

        static string ComparePersons(Person person1, Person person2)
        {
            bool equalParams = person1.Equals(person2);
            Object personobj = person1;
            bool fullEqual = personobj.Equals(person2);

            if (fullEqual)
                return "Абсолютно одинаковые объекты";
            if (equalParams)
                return "Одинаковые свойства объектов";

            return "Объекты разные";
        }
    }
}

