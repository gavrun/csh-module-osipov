using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Для автоматического формирования XML-справки:
1) откройте окно свойств проекта вкладку Сборка
2) в блоке Выходные данные поставьте флажок XML-файл документации (имя файла укажите на свое усмотрение)
XML-файл будет создан при сборке проекта. 
*/

namespace Hello
{   
    /// <summary> Класс MyF выводит приветствие на экран </summary> 
    class MyF
    {
        /// <summary>
        /// Метод выводит приветствие
        /// </summary>
        /// <remarks> We use console-based I/O.
        /// </remarks>
        public static void Hi()
        {        
            Console.WriteLine("Hello!");
        }

        /// <summary>
        /// Метод выводит приветствие со склейкой текста
        /// </summary>
        ///  <param name ="st" > Параметр передается для склейки со строкой </param>
        public void Pri(string st)
        {
           Console.WriteLine("Hello!" + " not " + st);
        }
    }



    class Hello
    {

        /// <param name = "args"> В методе принимается массив строк</param>
        /// <summary>
        /// Точка входа в приложение.
        /// </summary>
        static void Main(string[] args)
        {
            MyF Person = new MyF();
            MyF.Hi();
            Person.Pri("By");
        }
    }
}
