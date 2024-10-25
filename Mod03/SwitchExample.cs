using System;

namespace modu_3
{
    /// <summary>
    /// демонстрируется выражение switch, которое преобразует значения enum, 
    /// представляющие визуальные направления на интерактивной карте, 
    /// в соответствующие стороны света
    /// https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/switch-expression
    /// </summary>
    public static class SwitchExample
    {
        public enum Direction
        {
            Up,
            Down,
            Right,
            Left
        }

        public enum Orientation
        {
            North,
            South,
            East,
            West
        }

        public static Orientation ToOrientation(Direction direction) => direction switch
        {
            Direction.Up => Orientation.North,
            Direction.Right => Orientation.East,
            Direction.Down => Orientation.South,
            Direction.Left => Orientation.West,
            _ => throw new ArgumentOutOfRangeException(nameof(direction), $"Not expected direction value: {direction}"),
        };

        /// <summary>
        ///     Ветвление с помощью оператора switch
        ///     Оператор switch отличается от if тем, что проверяет одно выражение на соответствие трем или больше условиям (case)
        ///     Каждый оператор case относится к одному выражению. 
        ///     Каждый раздел case должен заканчиваться:
        ///     ключевыми словами break (коде ниже case 1)
        ///     ключевыми словами goto case (в коде ниже case 2)
        ///     не иметь никаких операторов (в коде ниже case 3)
        ///     ключевым словом goto, которое ссылается на именованную метку (в коде ниже case 5)
        ///     ключевым словом return для выхода из текущей функции (не показано в коде).
        /// </summary>
        public static void SwitchGoto(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("One");
                    break; // переход в конец оператора switch
                case 2:
                    Console.WriteLine("Two");
                    goto case 1;
                case 3: // блок, содержащий несколько случаев
                case 4:
                    Console.WriteLine("Three or four");
                    goto case 1;
                case 5:
                    goto A_label;
                default:
                    Console.WriteLine("Default");
                    break;
            } // конец оператора switch

            Console.WriteLine("After end of switch");
        A_label:
            Console.WriteLine($"After A_label");

        }
        public static void Main()
        {
            var direction = Direction.Right;
            Console.WriteLine($"Map view direction is {direction}");
            Console.WriteLine($"Cardinal orientation is {ToOrientation(direction)}");
            // Output:
            // Map view direction is Right
            // Cardinal orientation is East

            int number = (new Random()).Next(1, 7);
            Console.WriteLine($"My random number is {number}");
            SwitchGoto(number);
        }
    }
}
