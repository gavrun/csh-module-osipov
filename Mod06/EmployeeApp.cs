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
       
        // Конструкторы
        public Employee () { }
        public Employee(string name, int id, float pay)
        {
            empName = name;
            empID = id;
            currPay = pay;
        }
       
        // Методы
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }
       
        public void DisplayStats () // плохая идея - вывод на консоль
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine ("ID : {0}", empID);
            Console.WriteLine("Pay: {0}", currPay);
        }

        public override string ToString() // хорошая идея - переопределение метода
        {
            string stEmpl = string.Format("Name: {0}; ID : {1}; Pay: {2}", empName, empID, currPay);
            return stEmpl;
        } 

        // Метод доступа (метод get)
        public string GetName()
        {
            return empName;
        }

        // Метод изменения (метод set)
        public void SetName(string name)
        {
            // Перед присваиванием проверить входное значение
            if (name.Length > 15)
                Console.WriteLine ("Error 1 Name must be less than 16 characters!"); // обращение к консоли
            else
                empName = name;
        }
    }


    class EmployeeApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Encapsulation *****\n");
            Employee emp = new Employee("Marvin", 456, 30000); emp.GiveBonus(1000); emp.DisplayStats();

            // Использовать методы get/set для взаимодействия с именем объекта.
            emp.SetName("Marv");
            Console.WriteLine("Employee is named: {0}", emp.GetName());

            Console.WriteLine(emp);
                     
            // Длиннее 15 символов! На консоль выводится сообщение об ошибке.
            Employee emp2 = new Employee();
            emp2.SetName("Xena the warrior princess");


        }
    }
}
