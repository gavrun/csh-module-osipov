using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericT
{
    class Program
    {
        static void Main(string[] args)
        {
            //BoxUnbox();
            //Error();
            //GenericTyp();

            GenericBank();
        }

        private static void GenericBank()
        {
            Bank<int> bank = new Bank<int>(new int[] { 1, 2, 4, 5, 6 });
            Bank<string> bank2 = new Bank<string>(new string[] { "13433", "342454", "21432" });


            }

        private static void GenericTyp()
        {
            int x = 44;
            string s = "hello";

            List<int> array = new List<int>();

            array.Add(x);
            // Распаковка уже не нужна 
            int y = array[0];

            // здесь будет ошибка компиляции, так как можно добавлять только объекты int
            //array.Add(s);
        }

        private static void Error() // проблема безопасности типов - получим ошибку во время выполнения программы
        {
            int x = 44;

            System.Collections.ArrayList array = new System.Collections.ArrayList();
            // Упаковка значения x в тип Object
            array.Add(x);
            string s = "hello";
            // Добавление s в коллекцию ArrayList
            array.Add(s);
            // по индексу 1 в коллекции array строка s
            int y = (int)array[1];
        }

        private static void BoxUnbox()
        {
            int x = 44;

            System.Collections.ArrayList array = new System.Collections.ArrayList();
            // Упаковка значения x в тип Object
            array.Add(x);

            // Распаковка в значение типа int первого элемента коллекции
            int y = (int)array[0];

            Console.WriteLine(y);
        }
    }

    class Bank<T>
    {
        T[] clients;

        public Bank()
        {
        }
        public Bank(T[] _clients)
        {
            this.clients = _clients;
        }
    }
}
