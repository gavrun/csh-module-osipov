using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonClass
{
    class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(Person p)
        {
            FirstName = p.FirstName;
            LastName = p.LastName;
        }



        public string FirstName { get; set; }
        public string LastName { get; set; }

        // метод перевода объекта в строку
         public new string ToString()
      //  public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        // метод сравнения объектов
      //  public new bool Equals(Object obj)
        public override bool Equals(Object obj)
         {
             Person person = (Person)obj;
             return (FirstName == person.FirstName) &&
                    (LastName == person.LastName);
         }

        public string ComparePersons(Person person)
        {
            bool equalParams = Equals(person);
            bool fullEqual = base.Equals(person);

            if (fullEqual)
                return "Абсолютно одинаковые объекты";
            if (equalParams)
                return "Одинаковые свойства объектов";
            
            return "Объекты разные";
        }
    }
}
