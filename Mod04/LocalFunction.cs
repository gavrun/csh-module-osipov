using System;

namespace SimpleCSharpConsoleApp
{
    class MyClass
    {
        public static int AddWrapper(int x, int y)
        {
            //Do some validation here
            if (x != y)
            {
                return Add(x,y);
            }
            else
                return -1;
        }

        static int Add(int x, int y) // локальная функция
         {
                return x + y;
        }
    }
    class Program
    {
        static int Add(int x, int y) => x + y; // сокращенная запись

        static int AddWrapper(int x, int y)
        {
            //Do some validation here
            if (x != y)
            {
                return Add();
            }
            else
                return -1;            

            int Add() // локальная функция
            {
                return x + y;
            }
        }


        private static void Process(string[] lines, string mark)
        {
            foreach (var line in lines)
            {
                if (IsValid(line))
                {
                    // Processing logic...
                    Console.WriteLine(line);
                }
            }
            bool IsValid(string line) // локальная функция
            {
                return line.Length >= mark.Length;
            }
        }
		
        static void Main(string[] args) 
        {            
            int x = 200; int y = 201;

            int result2 = MyClass.AddWrapper(x, y);
            Console.WriteLine(result2);

            int result = AddWrapper(x,y);
            Console.WriteLine(result);

            string[] ls = {"Мама", "мыла", "раму"};
            Process(ls, "Два");
        }
    }
}
