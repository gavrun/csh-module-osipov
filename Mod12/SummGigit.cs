using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_17042023
{
    class SummGigit
    {
        public static void Main()
        {
         //   int myVal = boolMetod();

          SummGigit();

       }

        /// <summary>
        /// сумма цифр числа - вводимое число как строка - массив символов
        /// </summary>
        private static void SummGigit()
        {
            string value = Console.ReadLine();
            int summ = 0;
            foreach (var item in value)
            {
                summ += int.Parse(item.ToString());
            }
            
            Console.WriteLine(summ);
        }

        private static int boolMetod()
        {
            bool Ok = false;
            int myVal = 145;
            Ok = myVal < 100;

            Console.WriteLine(Ok);
            Console.WriteLine(myVal < '1');

            Console.WriteLine(myVal >= 100 == myVal <= 200);
            return myVal;
        }

    }
}
