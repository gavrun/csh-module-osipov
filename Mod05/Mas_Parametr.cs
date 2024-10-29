using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Print(int[] a) //n - размерность массива, а - ссылка на массив
        {
            for (int i = 0; i < a.Length; i++) Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }
        static void Change(int n, int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] < n) a[i] = 0; // изменяются элементы массива
        }
        static void Main()
        {
            int sum = 0;
            int[] myArray = { 100, 1, 32, 3, 14, 25, 6, 17, 8, 99 };
            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];//sum + myArray[i];
            }
            Console.WriteLine(sum);
            int arraySum = myArray.Sum();
            Console.WriteLine(arraySum);
            Print(myArray);
            Change(10, myArray);
            Print(myArray);
        }
    }

}

