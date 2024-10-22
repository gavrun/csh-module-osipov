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
            //Объявления локальных переменных
            int x, s; //без инициализации
            var t = 3;

            
            int y = 0, u = 77; //обычный способ инициализации
            t = 12;
            float w1 = 0f, w2 = 5.5f, w3 = w1 + w2 + 125.25f; //допустимая инициализация
            
            int z = new int();//допустимая инициализация в объектном стиле
            
          //int v = new int(77); //Недопустимая инициализация,конструктор с параметрами не определен
            
            x = u + y; //теперь x инициализирована

            if (x > 5)
                s = 101;
            for (x = 1; x < 5; x++) 
                s = 5;
          //  Console.WriteLine("s = {0}", s); //Ошибка компиляции:использование неинициализированной переменной

            dynamic xd = 3;     //  x1 - целочисленное int
            xd = xd + 5;
            Console.WriteLine(xd);

            object xo = 5;
            // xo = xo + 1;    // операция += не может быть применена к типам object
            Console.WriteLine(xo);

            xd = "Строка";          // x1 - строка
            Console.WriteLine(xd);
        }
    }
}
