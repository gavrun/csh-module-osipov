using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyConsole
{
    /// <summary>
    /// Этот класс содержит Main  и вывод в разноцветную консоль
    /// </summary>
    class Program
    {
        /// <summary>
        /// Метод для расчетов
        /// </summary>
        /// <param name="Aargs"></param>
        static void Main(string[] args)
        {
            Console.Title = "Новая жизнь";
            Console.BackgroundColor = ConsoleColor.White;
          Console.Clear();
            // меняю цвет текста на зеленый
            Console.ForegroundColor = ConsoleColor.Green;
           
            // следующие две строки текста будут зелеными
            Console.WriteLine("Здравствуй, Новое утро.");
            Console.WriteLine("Тебя приветствует полдень!");

            // меняю цвет текста на красный
            Console.ForegroundColor = ConsoleColor.Red;
            // следующие две строки текста будут красными
            Console.WriteLine("Здравствуй, Полдень.");
            Console.WriteLine("Признавайся, где был ночью?");

            Console.ReadLine();

        }
    }
}
