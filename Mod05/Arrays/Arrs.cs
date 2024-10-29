using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    /// <summary>
    /// Класс, статические методы которого 
    /// позволяют выполнять операции над массивами  
    /// </summary>
    class Arrs
    {
        private static Random rnd = new Random();
        /// <summary>
        /// Заполнение массива случайными числами
        /// в диапазоне [1, 100]
        /// </summary>
        /// <param name="A">массив, подлежащий заполнению</param>
        public static void CreateOneDimAr(int[] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
                A[i] = rnd.Next(1, 100);
        }//CreateOneDimAr
        /// <summary>
        /// Заполнение двумерного массива случайными числами
        /// в диапазоне [1, 100]
        /// </summary>
        /// <param name="A">массив, подлежащий заполнению</param>
        public static void CreateTwoDimAr(int[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                A[i, j] = rnd.Next(1, 100);
        }//CreateTwoDimAr

        /// <summary>
        /// печать массива
        /// </summary>
        /// <param name="name">имя массива</param>
        /// <param name="A"> массив</param>
        public static void PrintAr1(string name, int[] A)
        {
            Console.WriteLine(name);
            for (int i = 0; i < A.GetLength(0); i++)
                Console.Write("\t" + name + "[{0}]={1}", i, A[i]);
            Console.WriteLine();
        }//PrintAr1

        /// <summary>
        /// печать двумерного массива
        /// </summary>
        /// <param name="name">имя массива</param>
        /// <param name="A"> массив</param>
        public static void PrintAr2(string name, int[,] A)
        {
            Console.WriteLine(name);
            for (int i = 0; i < A.GetLength(0); i++)
                {for (int j = 0; j < A.GetLength(1); j++ )                
                    Console.Write("\t" + name + 
                        "[{0},{1}] = {2}", i, j, A[i,j]);
                 Console.WriteLine();
                }
        }//PrintAr2

        /// <summary>
        /// запрос у пользователя размеров матрицы
        /// </summary>
        /// <param name="name">имя матрицы</param>
        /// <param name="n1">число строк </param>
        /// <param name="m1">число столбцов</param>
        public static void GetSizes(string name, out int n1, out int m1)
        {
            Console.WriteLine("Для матрицы " + name +
                " введите число " + "строк");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Для матрицы " + name +
                " введите число " + "столбцов");
            m1 = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Умножение матриц С = A * B
        /// </summary>
        /// <param name="A">первый операнд</param>
        /// <param name="B">второй операнд</param>
        /// <param name="C">результат умножения матриц</param>
        public static void MultMatr(int[,] A, int[,] B, int[,] C)
        {
            if (A.GetLength(1) != B.GetLength(0))
                Console.WriteLine("MultMatr: ошибка размерности!");
            else
                for (int i = 0; i < A.GetLength(0); i++)
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        int s = 0;
                        for (int k = 0; k < A.GetLength(1); k++)
                            s += A[i, k] * B[k, j];
                        C[i, j] = s;
                    }
        }//MultMatr

        
        /// <summary>
        /// Печать дерева "Отцы и дети",
        /// заданного массивами Fathers и Children
        /// </summary>
        /// <param name="Fathers">массив отцов</param>
        /// <param name="Children"> массив массивов детей</param>
        public static void PrintAr3(string[] Fathers, string[][] Children)
        {
            for (int i = 0; i < Fathers.Length; i++)
            {
                Console.WriteLine("Отец : {0}; Его дети:", Fathers[i]);
                for (int j = 0; j < Children[i].Length; j++)
                    Console.Write(Children[i][j] + " ");
                Console.WriteLine();
            }
        }//PrintAr3
    }
}
