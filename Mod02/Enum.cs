using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enum
{
    class Program
    {
        enum gradus : int
        {
            min = 0,
            krit = 50,
            max = 100,
        }

        static void Main(string[] args)
        {
          Console.WriteLine("минимальная температура = " + (int)gradus.min);
          Console.WriteLine("критическая температура = " + (int)gradus.krit);
          Console.WriteLine("максимальная температура = " + (int)gradus.max);

          int tr;
          for (tr = 0; tr < 250; tr++)
          {
              if (tr < (int)gradus.krit)
                  Console.WriteLine("Процесс разрешен, температура " + tr);
              else
                  break;
          }
          Console.WriteLine("Стоп, температура " + tr);
        }
    }
}
