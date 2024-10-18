using System;

namespace MySpace {
    public class MyHelloWorld {
        public static void SayHello() {
            Console.WriteLine("Hello Hello");
        }

        public static void HandShake() {
            Console.WriteLine("Shake hands ");
        }
    }
}

namespace HelloWorldSpace {
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
}