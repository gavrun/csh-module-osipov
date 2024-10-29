using System;

namespace Pro_Array_Struct_Tuple
{
   struct Point
    {
        // Fields of the structure.
        public int x;
        public int y;

        // Add 1 to the (X, Y) position.
        public void Increment()
        {
            y++; y++;
        }

        // Subtract 1 from the (X, Y) position.
        public void Decrement()
        {
            x--; y--;
        }

        // Display the current position.
        public void Display()
        {
            Console.WriteLine($"X = {x}, Y = {y}");
        }

        // A custom constructor.
        public Point(int xPos, int yPos)
        {
            x = xPos;
            y = yPos;
        }
    }

    class Triangle
    {
        Point a;
        Point b;
        Point c;

        double area;
        public double Area
        {
            get
            {
                return area = Math.Abs((a.x - c.x) * (b.y - c.y) - (b.x - c.x) * (a.y - c.y)) / 2; ;
            }
        }


        public Triangle(Point pa, Point pb, Point pc)
        {
            a = pa;
            b = pb;
            c = pc;
        }
        public double getArea()
        {
            return Math.Abs((a.x - c.x) * (b.y - c.y) - (b.x - c.x) * (a.y - c.y)) / 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Tuple  - ссылочный тип
            var population = new Tuple<string, int, int, int, int, int, int>(
                                       "New York", 7891957, 7781984,
                                       7894862, 7071639, 7322564, 8008278);
            // Display the first and last elements.
            Console.WriteLine("Population of {0} in 2000: {1:N0}",
                              population.Item1, population.Item7);// Элементами данных являются свойства

            // ValueTuple - размерный тип
            // Кортежи ValueTuple являются типами значений, а элементы кортежа — общедоступными полями. 
            // имена полей по умолчанию Item1, Item2, Item3 и т. д
            (double, int) t1 = (4.5, 3);    
            var t2 = (8.8, 45);
            Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");
            Console.WriteLine($"Tuple with elements {t2.Item1} and {t2.Item2}.");

            // Имена могут быть добавлены к каждому свойству кортежа и справа и слева от оператора =
            // Имена полей кортежей указываются явным образом 
            (string FirstLetter, int TheNumber, string SecondLetter) valuesWithNames = ("a", 5, "c");
            var valuesWithNames2 = (FirstLetter: "a", TheNumber: 5, SecondLetter: "c");
            Console.WriteLine($"First item: {valuesWithNames.FirstLetter}");
            Console.WriteLine($"Second item: {valuesWithNames2.TheNumber}");
            Console.WriteLine($"Third item: {valuesWithNames2.SecondLetter}");

            // если имя поля не указано, оно может быть выведено из имени соответствующей переменной в выражении инициализации кортежа
            var sum = 14.5;
            var count = 23;
            var t = (sum, count);
            Console.WriteLine($"Sum of {t.count} elements is {t.sum}.");

            // Значения элементов кортежа присваиваются в порядке расположения элементов кортежа.
            // Имена полей кортежа не учитываются и не присваиваются
            (int, double) t11 = (17, 3.14);
            (double First, double Second) t21 = (0.0, 1.0);
            t21 = t11;
            Console.WriteLine($"{nameof(t21)}: {t21.First} and {t21.Second}");

            // Способа деконструкции кортежа.
            // 1. Явно объявить тип каждой переменной в скобках.
            var t31 = ("post office", 3.6);
            (string destination, double distance) = t31;
            Console.WriteLine($"Distance to {destination} is {distance} kilometers.");
            // 2. Использовать ключевое слово var за пределами круглых скобок, чтобы объявить неявно типизированные переменные и позволить компилятору вывести их типы.
            var t32 = ("post office", 3.6);
            var (destination2, distance2) = t32;
            Console.WriteLine($"Distance to {destination2} is {distance2} kilometers.");
            // 3. Использовать существующие переменные.
            var destination3 = string.Empty;
            var distance3 = 0.0;

            var t33 = ("post office", 3.6);
            (destination3, distance3) = t33;
            Console.WriteLine($"Distance to {destination3} is {distance3} kilometers.");

            // Равенство кортежей - операторы == и !=.
            // Эти операторы сравнивают элементы левого операнда с соответствующими элементами правого операнда в соответствии с порядком расположения элементов кортежа.
            (int a, byte b) left = (5, 10);
            (long a, int b) right = (5, 10);
            Console.WriteLine(left == right);  // output: True
            Console.WriteLine(left != right);  // output: False

            var t41 = (A: 5, B: 10);
            var t42 = (B: 5, A: 10);
            // в операциях == и != не учитываются имена полей кортежей
            Console.WriteLine(t41 == t42);  // output: True
            Console.WriteLine(t41 != t42);  // output: False

            //Кортежи используются как возвращаемый методом тип (вместо out)
            var xs = new[] { 14, 27, 39, 7 };
            var limits = FindMinMax(xs);
            Console.WriteLine($"Limits of [{string.Join(" ", xs)}] are {limits.min} and {limits.max}");

            // тип кортежа может иметь параметр out  
            var limitsLookup = new System.Collections.Generic.Dictionary<int, (int Min, int Max)>()
            {
                [2] = (4, 10),
                [4] = (10, 20),
                [6] = (0, 23)
            };

            if (limitsLookup.TryGetValue(4, out (int Min, int Max) limits2))
            {
                Console.WriteLine($"Found limits: min is {limits2.Min}, max is {limits2.Max}");
            }

            TestPoint(); // проверка структуры Point

            // int[] intArray = new int[2] { 20, 22, 23, 0 }; // список инициализации превышает 2
            // int[] intArray = new int[22] { 20, 22, 23, 0 }; // требуется 22-элемента
            
            // b is really double[].
            var b = new[] { 1, 1.5, 2, 2.5 };
            //var bb = new[] { 1, "one", 2, "two", false }; // нет подходящего типа

            IndexAndRangesFunctionality(); // тестирование диапазонов 
            Arrays(); // тестирование многомерных массивов
            ArraysJ(); // тестирование массива массивов
        }

        public static void TestPoint()
        {
            Point myPoint;                  // переменная структуры
            myPoint.x = 349;
            myPoint.y = 76;
            myPoint.Display();

            // Adjust the X and Y values.
            myPoint.Increment();
            myPoint.Display();

            // Set all fields to default values
            // using the default constructor.
            Point p1 = new Point();

            // Prints X=0,Y=0
            p1.Display();

            // Call custom constructor.
            Point p2 = new Point(50, 60);

            // Prints X=50,Y=60
            p2.Display();
        }

        public static (int min, int max) FindMinMax(int[] input)
        {
            if (input is null || input.Length == 0)
            {
                throw new ArgumentException("Cannot find minimum and maximum of a null or empty array.");
            }

            var min = int.MaxValue;
            var max = int.MinValue;
            foreach (var i in input)
            {
                if (i < min)
                {
                    min = i;
                }
                if (i > max)
                {
                    max = i;
                }
            }
            return (min, max);
        }


        static void IndexAndRangesFunctionality()
        {
            Console.WriteLine("=> Working with Indices and Ranges.");
            // Initialize items at startup.
            string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

            // ... and print them.
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Index idx = i;
                // Print a name
                Console.Write(gothicBands[idx] + ", ");
            }
            Console.WriteLine("\n");
            for (int i = 1; i <= gothicBands.Length; i++)
            {
                Index idx = ^i;
                // Print a name
                Console.Write(gothicBands[idx] + ", ");
            }
            Console.WriteLine("\n");

            foreach (var itm in gothicBands[0..2])
            {   // Print a name
                Console.Write(itm + ", ");
            }
            Console.WriteLine("\n");
            Range r = 0..2; //the end of the range is exclusive
            foreach (var itm in gothicBands[r])
            {   // Print a name
                Console.Write(itm + ", ");
            }
            Console.WriteLine("\n");
            Index idx1 = 0;
            Index idx2 = 2;
            r = idx1..idx2; //the end of the range is exclusive
            foreach (var itm in gothicBands[r])
            {   // Print a name
                Console.Write(itm + ", ");
            }
            Console.WriteLine("\n");

            Console.WriteLine($"Array length is {gothicBands[..].Length}");
            Console.WriteLine($"Array length is {gothicBands[0..3].Length}");
            Console.WriteLine($"Array length is {gothicBands[0..^0].Length}");
        }
        public static void Arrays()
        {
            // Two-dimensional array.
            int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // The same array with dimensions specified.
            int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // A similar array with string elements.
            string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
                                        { "five", "six" } };

            // Three-dimensional array.
            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                 { { 7, 8, 9 }, { 10, 11, 12 } } };
            // The same array with dimensions specified.
            int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                       { { 7, 8, 9 }, { 10, 11, 12 } } };

            // Accessing array elements.
            System.Console.WriteLine(array2D[0, 0]);
            System.Console.WriteLine(array2D[0, 1]);
            System.Console.WriteLine(array2D[1, 0]);
            System.Console.WriteLine(array2D[1, 1]);
            System.Console.WriteLine(array2D[3, 0]);
            System.Console.WriteLine(array2Db[1, 0]);
            System.Console.WriteLine(array3Da[1, 0, 1]);
            System.Console.WriteLine(array3D[1, 1, 2]);

            // Getting the total count of elements or the length of a given dimension.
            var allLength = array3D.Length;
            var total = 1;
            for (int i = 0; i < array3D.Rank; i++)
            {
                total *= array3D.GetLength(i);
            }
            System.Console.WriteLine("{0} equals {1}", allLength, total);
        }

        public static void ArraysJ()
        {
                // Declare the array of two elements.
                int[][] arr = new int[2][];

                // Initialize the elements.
                arr[0] = new int[5] { 1, 3, 5, 7, 9 };
                arr[1] = new int[4] { 2, 4, 6, 8 };

                // Display the array elements.
                for (int i = 0; i < arr.Length; i++)
                {
                    System.Console.Write("Element({0}): ", i);

                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                    }
                    System.Console.WriteLine();
                }
            
        }
        /* Output:
            Element(0): 1 3 5 7 9
            Element(1): 2 4 6 8
        */
    }

}

