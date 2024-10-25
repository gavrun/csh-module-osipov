using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{ // 1. Наибольший общий делитель
	  // 24 18
	  // 2 4 6 8 12 --- 2 3 4 6 9 === 2 4 6
	  // Евклида
	  // вычитаем из большего
	  // 24-18 = 6
	  // 18 - 6 = 12
	  // 12 - 6 = 6
	  // 6 = 6 ---НОД!

		public static int NodMy(int x1, int x2)
        {
			while (x1 != x2)
			{
				if (x1 < x2)
					x2 = x2 - x1;
				else
					x1 = x1 - x2;
			}
			return x1;
		}

		public static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			// 1.
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			//while (a != b)
			//{
			//	if (a < b)
			//		b = b - a;
			//	else
			//		a = a - b;
			//}

			int rez = Program.NodMy(a, b);
			Console.WriteLine("NOD: " + rez);



			// 2. Расчет значения параметров функции на заданном интервале 
			double x = 0, y = 0;
			double x1 = 0;
			double x2 = 1;
			x = x1;
			do
			{
				y = x * x;
				Console.WriteLine("x: " + x + "\ty: " + y);
				x = x + 0.1;
			}
			while (x <= x2);
			
			
			// 3. Сумма чисел на интервале от 1 до 100, но для 1 до k и от m до 100
			int k = int.Parse(Console.ReadLine());
			int m = int.Parse(Console.ReadLine());
			int s = 0;
			for (int i = 1; i <= 100; i++)
			{
				if (i > k && i < m) continue;
				s += i;
			}
			Console.WriteLine("s: " + s);

			// задание - реализовать расчет суммы цмфр любого целого числа
			// 2356 - 16
		}
	}
}