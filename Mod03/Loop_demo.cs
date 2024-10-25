using System;


namespace modu_2_
{
    /// <summary> 
    /// Задача 1.
    /// Требуется реализовать печать заголовка таблицы вывода значений функции
    /// С помощью цикла с постусловием реализуйте вывод значений функции sin(x) на интервале от x1 до x2 с шагом 0,01
    /// Используйте четыре переменных вещественного типа:
    /// x – аргумент функции, x1, x2 – границы интервала, y – выходной параметр функции, 
    /// для границ интервала реализуйте ввод значений  с клавиатуры.
    /// Задача 2.
    /// Требуется определить наибольший общий делитель двух целых чисел по алгоритму Евклида
    /// a и b -входные данные
    /// nod - искомое значение
    /// </summary>
    
    class LoopProgram
    {
        static void Main()
        {
            // 1
            double y;
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());

            double x = x1;
            do
            {
                y = Math.Sin(x);
                Console.WriteLine("{0:0.00}\t{1:0.00}", x, y);
                x += 0.01;
            }
            while (x <= x2);

            // 2
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;

                //  _ = a > b ? a -= b : b -= a;
                // о пустой переменной:
                // https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/functional/discards#a-standalone-discard
            }
            int nod = a;
            Console.WriteLine("nod = " + nod);
        }

    }
}
