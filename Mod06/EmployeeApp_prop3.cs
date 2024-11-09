using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeApp
{
    class Employee
    {
       // Поля данных
        private string empName;

        public int Age { get; set; } // автоматическое свойство 
        public int ID { get; set; } // автоматическое свойство
        public double Pay { get; set; } // автоматическое свойство


        // Свойства
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    empName = null;
                else
                    empName = value;
            }
        }

       // Конструкторы
        public Employee () 
        {
            Age = 10;
        }

        public Employee(string name, int id, double pay)
            : this(name, 20, id, pay) { }


        public Employee(string name, int age, int id, double pay)
        {
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;
        }
        
        // Методы
        public void GiveBonus(double amount)
        {
            Pay += amount;
        }

     //   public override string ToString() // хорошая идея - переопределение метода
    //    {
    //        string stEmpl = string.Format("Name: {0}; ID : {1}; Pay: {2}; Age: {3}", Name, ID, Pay, Age);
    //        return stEmpl;
    //    } 
		
		/*
		Тело многих создаваемых членов класса может состоять только из одного оператора, который может быть представлен как выражение. 
		Можно сократить этот синтаксис, написав выражение. 
		Это работает для методов и свойств, доступных только для чтения
		*/
		public override string ToString() => $"Name: {Name}; ID : {ID}; Pay: {Pay}; Age: {Age3}";
		public string FullInfo => $"{Name}, {Age}"; // новое свойство - только для чтения
    }


    class EmployeeApp_prop2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Encapsulation *****\n");
            Employee emp = new Employee("Marvin", 456, 30000); 
            emp.GiveBonus(1000);
            Console.WriteLine(emp); 

            // Установка и получение свойства Name
            emp.Name = "Marv";
            Console.WriteLine("Employee is named: {0}", emp.Name);

            // Установка и получение свойства Name
            emp.Name = "Xena the warrior princess"; // Длиннее 15 символов! На консоль выводится сообщение об ошибке.
            Console.WriteLine("Employee is named: {0}", emp.Name);

            Employee emp2 = new Employee("Xena the warrior princess", 1456, 3);
            emp2.GiveBonus(100);

            if (emp2.Name == null)
                emp2.Name = "Возможно ошибка";
            Console.WriteLine(emp2);

            Employee joe = new Employee();
            joe.Age++;
            Console.WriteLine(joe);
        }
    }
}
