using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Count2
{

class Counter
{
private int count;	// значение счетчика

public Counter()
{
    Console.WriteLine("Работает конструктор 1\n");
    count = 0;	// конструктор
}

 public int GetCount ( ) // получить значение
{ return count; }

public void SetCount(int c)
{
	count = c;
}

public void IncrVal ( int k)	// увеличить значение
{ count+=k; }
};

class Count2
{

    private Counter c2;

    public Count2() 	// конструктор
    { Console.WriteLine("Работает конструктор 2\n");
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
        return c2.GetCount();
    }

    public void IncVal(int k)
    {
        c2.IncrVal(k);
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            Count2 cc2 = new Count2();
            cc2.SetCount(99);
            cc2.IncVal(1);
            cc2.Decr(2);

            Console.WriteLine("\ncc2= {0} ", cc2.GetCount());
        }
    }
}
