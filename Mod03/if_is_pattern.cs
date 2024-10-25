using System;

namespace modu_3
{
    /// <summary>
    /// Шаблоны объявления и шаблоны типов используются для проверки того, 
    /// совместим ли с указанным типом тип определенного выражения в среде выполнения. 
    /// </summary>
    public class MyClass
    {       
        public static void Main()
        {
            object greeting = "Hello, World!";
            if (greeting is string message)
            {
                // С помощью шаблона объявления можно объявить новую локальную переменную
                string greetnew = message.ToLower();
                Console.WriteLine(greetnew);  // output: hello, world!
            }

       }
    }
   
}