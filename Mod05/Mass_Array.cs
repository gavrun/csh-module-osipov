using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mass_Array
{
    class Mass_Array
    {
        static void Main(string[] args)
        {
            int[] mas1 = {};
            int[] mas2;
            int[] mas11 = new int[5];
         //   Console.WriteLine(mas1[0]); // исключение при выполнении (индекс вне диапазона)
         //   Console.WriteLine(mas2[1]); // ошибка при компиляции

            int[] mas3 = new[] { 1, 2, 3, 4, 5 };
            int[] mas33 = new[] { 13, 23, 33, 43, 53 };

            mas1 = mas3;
            mas1[1] = 20;
            Console.WriteLine(mas3[1]); //  20

            mas2 = mas33;
            mas2[1] = 10;
            Console.WriteLine(mas33[1]);    // 10

            mas3.CopyTo(mas11, 0); // копирование элементов из исходного массива в целевой массив
            mas11[1] = 200;
            Console.WriteLine(mas3[1]); //  все равно 20

            // массив с заданным значением
            var array = new bool[3].Select(e => 4).ToArray(); // 4 4 4 
           
            // преобразование массива
            int[] nma1 = mas1.Select(i => i * 3).ToArray();   
            
            // объединение массивов
            int[] allNum = mas1.Union(mas2).ToArray();

            // получение уникальных значений
            int[] masunique = array.Distinct().ToArray(); // 4

            // проверка наличия элемента
            var b1 = mas1.Contains(4); // true
            var b11 = mas1.ToList().IndexOf(4); // 3

            // проверка равенства
            bool b111 = mas1.SequenceEqual(mas3); // true значений
            bool b222 = (mas1 == mas3);            // true ссылок

            int[] mas33n = new[] { 1, 20, 3, 4, 5 };
            bool b33 = (mas1 == mas33n);            // false ссылок
            bool b333 = mas1.SequenceEqual(mas33n); // true значений

            // сортировка
            Array.Sort(mas1);

            // применение Linq
            mas33n = mas33n.OrderBy(i => i).ToArray();
            mas33n = mas33n.OrderByDescending(i => i).ToArray();

            // Linq для фильтрации

            var items = mas1.Where(i => i % 2 == 0).ToArray(); // отбор четных чисел
        }
    }
}
