using System;

namespace modu_4
{
    class Discards_out
    {
        static bool IsInt1(string s)
        {
            int temp;
            return int.TryParse(s, out temp);
        }

        // можно избавиться от переменной temp 
        static bool IsInt2(string s)
        {
            return int.TryParse(s, out _);
        }

        // однострочный метод
        static bool IsInt3(string s) => int.TryParse(s, out _);

        static void Main()
        {
            string st = "123u";
            Console.WriteLine(IsInt1(st));
            Console.WriteLine(IsInt2(st));
            Console.WriteLine(IsInt3(st));
        }
    }
}
