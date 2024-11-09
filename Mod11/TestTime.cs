namespace Time
{
using System;

/// <summary>
///    Summary description for TestTime.
/// </summary>
public class TestTime
{
	public static void Main() 
	{
		Time t1 = new Time(100);
		Time t2 = new Time(9, 65);

		Console.WriteLine("{0}, {1}", t1, t2);

        Time t = t1--;
		Console.WriteLine(t.ToString());
		Console.WriteLine(t1.ToString());

        t = --t1;
        Console.WriteLine(t.ToString());
        Console.WriteLine(t1.ToString());

        t2++;
		Console.WriteLine("{0}, {1}", t1, t2);

		Console.WriteLine("t1 is{0}less than t2", t1 < t2 ? " " : " not ");
		
		t1++;
		Console.WriteLine("{0}, {1}", t1, t2);
		Console.WriteLine("t1 is{0}less than t2", t1 < t2 ? " " : " not ");

		t1 = t1 - 55;
		Console.WriteLine("{0}, {1}", t1, t2);
		Console.WriteLine("t1 is{0}less than t2", t1 < t2 ? " " : " not ");

		t2 -= 123;
		Console.WriteLine("{0}, {1}", t1, t2);

		Console.WriteLine("{0}", t2 - t1);

		int minsInt = 115;
		float minsFloat = 123.45F;

		Time t3 = (Time)minsInt;
		Time t4 = (Time)minsFloat;
		Console.WriteLine("{0}, {1}", t3, t4);

		t3 += 3;
		minsInt = (int)t4;
		minsFloat = t3;
		Console.WriteLine("minsInt:{0}\t\tminsFloat:{1}", minsInt, minsFloat);
	}
}
}
