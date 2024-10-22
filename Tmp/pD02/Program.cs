using System;
//#error version
//namespace pD02
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
            /*
            Hello, Vasja!
            Hello, Kolya!
            Hello, Petja!
            Good bye, Vasja!
            Good bye, Kolya!
            Good bye, Petja!
             */
            foreach (var item in args)
            {
                Console.WriteLine($"Hello, {item}!");
            }

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Good bye, {args[i]}!");
            }

/* Задание. 
 Измените второй цикл так, чтобы прощания были от последнего к первому:
Hello, Vasja!
Hello, Kolya!
Hello, Petja!
Good bye, Petja!
Good bye, Kolya!
Good bye, Vasja!
*/
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
            {
               Console.WriteLine($"Arg: {arg}");
            }

            ShowEnvironmentDetails();
/*Метод GetCommandLineArgs не получает аргументы для приложения через Main() 
 * и не зависит от параметра string[] args.
 Первая запись содержит имя самого приложения, 
 а остальные элементы в массиве содержат отдельные аргументы командной строки
 */
// Класс Environment предоставляет ряд чрезвычайно полезных методов помимо GetCommandLineArgs()
static void ShowEnvironmentDetails()
{
    // Print out the drives on this machine,
    // and other interesting details.
    foreach (string drive in Environment.GetLogicalDrives())
    {
        Console.WriteLine("Drive: {0}", drive);
    }
    Console.WriteLine("OS: {0}", Environment.OSVersion);
    Console.WriteLine("Number of processors: {0}",
    Environment.ProcessorCount);
    Console.WriteLine(".NET Core Version: {0}",
    Environment.Version);
}

//        }
//    }
//}





/*
 Решение
            for (int i = args.Length-1; i >= 0; i--)
            {
                Console.WriteLine($"Good bye, {args[i]}!");
            }
 */