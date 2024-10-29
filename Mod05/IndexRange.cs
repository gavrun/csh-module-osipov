using System;

namespace modu_5
{
    /// <summary>
    /// Индексы и диапазоны
    /// https://learn.microsoft.com/ru-ru/dotnet/csharp/tutorials/ranges-indexes
    /// </summary>
    class IndexRange
    {
        static void Main(string[] args)
        {
            int[] myArray = { 100, 1, 32, 3, 14, 25, 6, 17, 8, 99 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Index idx = i;
                Console.Write(myArray[idx] + ", ");
            }
            Console.WriteLine("\n");

            for (int i = 1; i <= myArray.Length; i++)
            {
                Index idx = ^i;
                Console.Write(myArray[idx] + ", ");
            }

            // последний элемент
            Console.WriteLine($"\nThe last is {myArray[^1]}");      // 99

            /*
             range-оператор [start..end] указывает начало и конец диапазона. 
            Начало диапазона является включающим, конец диапазона является исключающим,
            то есть начало включается в диапазон, а конец не включается
             */
            Range r = 1..5;
            foreach (var itm in myArray[1..5]) // myArray[r]
            {
                Console.Write(itm + ", ");      // 1, 32, 3, 14,
            }
            Console.WriteLine("\n");

            // можно и так 
            Index idx1 = 0;
            Index idx2 = 2;
            Range rng = idx1..idx2;

        }
    }
}
