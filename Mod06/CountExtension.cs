using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Count2
{

public class Counter
{
    private int count;	// значение счетчика
    
    public Counter()    // конструктор
    {
    Console.WriteLine("Работает конструктор 1");
    count = 0;	
    }
    
    public int GetCount( ) // получить значение
    { return count; }
    
    public void SetCount(int c)
    {
	count = c; 
    }

    
    public void IncVal( int k)	// увеличить значение
    { count+=k; }
};

class Count2
{

    public Counter c2;

    public Count2() 	// конструктор
    { Console.WriteLine("Работает конструктор 2");
        c2 = new Counter();
    }

    public void Decr(int k)	//  уменьшаем значение
    {
        int temp = c2.GetCount();
        temp -= k;
        c2.SetCount(temp);
    }

    public void SetCount(int c)
    {
        c2.SetCount(c);
    }

    public int GetCount()
    {
      return  c2.GetCount();
    }


    public void Rost(int k)
    {
        c2.IncVal(k);
    }
}

// Определение метода расширения

/* Методы расширения представляют собой удобный способ добавления методов в классы, 
 которые вам не принадлежат и поэтому не могут быть изменены напрямую */
    public static class CountExtension
    {
        public static void Decr(this Counter c, int k)
        {
            int temp = c.GetCount();
            temp -= k;
            c.SetCount(temp);
        }

    }

   class Program
    {
        static void Main(string[] args)
        {
            int[] mas33n = new[] { 1, 20, 3, 4, 5 };

            //Count2 cc2 = new Count2();
            //cc2.SetCount(99);
            //cc2.Rost(1);
            //cc2.Decr(2);
            //Console.WriteLine("\ncc2= {0} ", cc2.GetCount());

            Counter c = new Counter();
            c.SetCount(10);
            c.IncVal(2);
            c.Decr(4);      // Применение метода расширения
            Console.WriteLine("c = {0} ", c.GetCount());
        }
    }
}
