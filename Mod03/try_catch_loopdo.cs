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
            do
            {
                try
                {
                    Console.WriteLine("Введите аргумент");
                    double x = double.Parse(Console.ReadLine());    // 1 ситуация              
                    double y = 1 / x;   // 2 ситуация
                    Console.WriteLine("y={0}", y);
                    Console.WriteLine("блок try выполнился успешно");
                    break;
                }
                catch (FormatException)  // обработка 1 ситуации
                {
                    Console.WriteLine("Ошибка: введено нечисловое значение!, повторите ввод");
                }
                catch (Exception error) // обработка 2 ситуации
                {
                    Console.WriteLine("Ошибка: {0}, повторите ввод", error);
                }
                
            } while (true);
            Console.WriteLine("конец программы");

        }
    }
}
