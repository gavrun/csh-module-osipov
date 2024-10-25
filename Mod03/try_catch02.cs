using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = int.Parse(Console.ReadLine());    // 1 ситуация              
                int y = 1 / x;   // 2 ситуация
                Console.WriteLine("y={0}", y);
                Console.WriteLine("блок try выполнился успешно");
            }
            catch (FormatException)  // обработка 1 ситуации
            {
                Console.WriteLine("Ошибка: введено нечисловое значение!");
            }
          catch (Exception error) // обработка 2 ситуации
            {
               Console.WriteLine("Ошибка: {0}", error);
            }
            Console.WriteLine("конец программы");

        }
    }
}
