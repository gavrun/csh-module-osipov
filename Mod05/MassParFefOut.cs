using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MassParFefOut
{
    class Program
    {
        static void enter(out int[] massiv1)
        {
            int i, N;
            //вводим число элементов
            Console.Write("Введите число элементов массива N = ");
            N = Convert.ToInt32(Console.ReadLine());

            //создаём массив необходимой длины
            massiv1 = new int[N];

            //запускаем цикл по всем элементам массива
            for (i = 0; i < N; i++)
            {
                //вводим i-ый элемент
                Console.Write("Введите {0}-й элемент массива ", i);
             massiv1[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void process( int[] massiv1)
        {
            for (int j = 0; j < massiv1.Length; j++)
            {
                int f = 1;
                for (int i = 2; i <= massiv1[j]; i++)
                    f = f * i;
                massiv1[j] = f;
            }
        }
        static void output(int[] mas)
        {
            Console.WriteLine("Итоговый массив:");
            mas[0] = 100;
              mas = new int[] { 9, 1, 10, 8 };
            foreach (int i in mas)
                Console.WriteLine("{0} ", i);
        }

        static void output(ref int[] mas)
        {
            Console.WriteLine("Итоговый массив:");
            //  mas = new int[] { 9, 1, 10, 8};
                mas[0] = 100;
            foreach (int i in mas)
                Console.WriteLine("{0} ", i);
            
        }

        static void Main(string[] args)
        {
            int[] my_massiv;
            enter(out my_massiv);
            process(my_massiv);

            output(my_massiv);
            foreach (int i in my_massiv)
                Console.WriteLine("m{0} ", i);


            output(ref my_massiv);

            foreach (int i in my_massiv)
                Console.WriteLine("m{0} ", i);
        }

    }
}
