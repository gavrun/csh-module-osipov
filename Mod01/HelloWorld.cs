using System;
class HelloWorld {
  static void Main() {
            Console.WriteLine("Hello World");
            int a, b;
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"c = {c}");
  }
}