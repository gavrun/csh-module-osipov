using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeApp
{
    class Employee
    { // Поля данных
        private string empName;
        private int empID; 
        private float currPay;

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

        public int ID 
        {
            get { return empID; } 
            set { empID = value; }
        }
        public float Pay 
        {
            get { return currPay; }
            set { currPay = value; }
        }
    


        // Конструкторы
        public Employee () { }
        public Employee(string name, int id, float pay)
        {
            Name = name;
            ID = id;
            Pay = pay;
        }
        
        // Методы
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }
        public override string ToString() // хорошая идея - переопределение метода
        {
            string stEmpl = string.Format("Name: {0}; ID : {1}; Pay: {2}", Name, ID, Pay);
            return stEmpl;
        } 
    }


    class EmployeeApp_prop
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
                emp2.Name = "Была ошибка";
            Console.WriteLine(emp2); 

        }
    }
}
