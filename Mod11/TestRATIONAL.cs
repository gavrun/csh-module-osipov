namespace Rational
{
using System;

// Test harness
public class TestRational
{
	public static void Main()
	{
		// Create two Rationals - r1 and r2
		Rational r1 = new Rational(1, 2);
		Rational r2 = new Rational(1, 3);
		//Rational r2 = new Rational(2, 4);

		// Print them out
		Console.WriteLine("r1 is {0}\tr2 is {1}", r1, r2);

		// Is r1 > r2?
		if (r1 > r2) {
			Console.WriteLine("{0} > {1}", r1, r2);
		} else {
			Console.WriteLine("{0} is not > {1}", r1, r2);
		}

		// Is r1 <= r2?
		if (r1 <= r2) {
			Console.WriteLine("{0} <= {1}", r1, r2);
		} else {
			Console.WriteLine("{0} is not <= {1}", r1, r2);
		}

		// Is r1 != r2?
		if (r1 != r2) {
			Console.WriteLine("{0} != {1}", r1, r2);
		} else {
			Console.WriteLine("{0} is not != {1}", r1, r2);
		}

		// Add r2 to r1
		r1 = r1 + r2;
		Console.WriteLine("r1 + r2 is {0}", r1);

		// Add 5 to r2
		r2 += 5;
		Console.WriteLine("r2 + 5 is {0}", r2);

		// Subtract r1 from r2
		r2 -= r1;
		Console.WriteLine("r2 - r1 is {0}", r2);

		// Subtract 2 from r2
		r2 = r2 - 2;
		Console.WriteLine("r2 - 2 is {0}", r2);

		// Increment r1
		r1++;
		Console.WriteLine("r1++ is {0}", r1);

		// Decrement r2
		r2--;
		Console.WriteLine("r2-- is {0}", r2);

		// Convert r2 into a float
		float f = (float)r2;
		Console.WriteLine("f is {0}", f);

		// Convert r2 into an int
		int i = (int)r2;
		Console.WriteLine("i is {0}", i);

		// Assign r2 from an integer
		r2 = 7;
		Console.WriteLine("r2 is {0}", r2);

		// Multiply r1 by r2 and store in r3
		Rational r3 = r1 * r2;
		Console.WriteLine("{0} * {1} is {2}", r1, r2, r3);

		// Multiply r2 by 4 and store in r3
		r3 = r2 * 4;
		Console.WriteLine("{0} * 4 is {1}", r2, r3);

		// Divide r2 by r1 and store in r3
		r3 = r2 / r1;
		Console.WriteLine("{0} / {1} is {2}", r2, r1, r3);

		// Divide r1 by 3 and store in r3
		r3 = r1 / 3;
		Console.WriteLine("{0} / 3 is {1}", r1, r3);

		// Test 37/6 % 3 (answer should be 1/6)
		r3 = new Rational(37, 6) % 3;
		Console.WriteLine("37/6 % 3 is {0}", r3);
	}
}
}
