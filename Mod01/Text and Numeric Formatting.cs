using System;

namespace Text_and_Numeric_Formatting
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>

		static void Main(string[] args)
		{
			Console.WriteLine("The sum of {0} and {1} is {2}", 100, 130, 100+130);
			Console.WriteLine("\"Left justified in a field of width 10: {0,-10}\"",99);
			Console.WriteLine("\"Right justified in a field of width 10: {0,10}\"",99);
			
			Console.WriteLine();

			Console.WriteLine("Currency formatting - {0:C}", 88.8);
			Console.WriteLine("Integer formatting - {0:D5}",88);
			Console.WriteLine("Exponental formatting - {0:E}",888.8);
			Console.WriteLine("Fixed-point formatting - {0:F3}", 888.8888);
            Console.WriteLine("General formatting - {0:G}", 888.8888);
			Console.WriteLine("Number formatting - {0:N}", 8888888.8);
			Console.WriteLine("Hexademical formatting - {0:X4}", 88);

            
		}
	}
   
 
}
