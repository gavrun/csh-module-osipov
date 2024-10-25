using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        
            
{
 byte n = 1; byte i;
 try
 {
  unchecked	//блок без проверки
  {
   for (i = 1; i < 10; i++) n *= i;
   Console.WriteLine("1: {0}", n);
  }
  checked 	//блок с проверкой
  {
   n=1;
   for (i = 1; i < 10; i++) n *= i;
   Console.WriteLine("2: ", n);
  }
 }
 catch (OverflowException)
 {
  Console.WriteLine("возникло переполнение");
 }
}

        
    }
}
