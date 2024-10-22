using System;
namespace modu_2_
{
    /// <summary>
    /// Моделируется простая дробь
    /// </summary>
    struct Fraction
    {
        public int numerator;
        public int denominator;

        //public Fraction(int n, int d = 1)
        //{
        //    numerator = n;
        //    denominator = d;
        //}

    }

    class ProgramFraction
    {
        /// <summary>
        /// Создаются две простые дроби и затем третьей присваивается их произведение
        /// </summary>
        static void Main()
        {
            Fraction frac1, frac2;
            Console.WriteLine("Введите первую дробь:");
            Console.Write("Числитель: ");
            frac1.numerator = int.Parse(Console.ReadLine());
            Console.Write("Знаменатель: ");
            frac1.denominator = int.Parse(Console.ReadLine());

            Console.WriteLine("\nВведите вторую дробь:");
            Console.Write("Числитель: ");
            frac2.numerator = int.Parse(Console.ReadLine());
            Console.Write("Знаменатель: ");
            frac2.denominator = int.Parse(Console.ReadLine());

            Fraction result;// = new Fraction(1);
            //Console.WriteLine("\nНовая дробь: {0}/{1}", result.numerator, result.denominator);
            result.numerator = frac1.numerator * frac2.numerator;
            result.denominator = frac1.denominator * frac2.denominator;

            // Fraction result = MultiplyFractions(frac1, frac2);
            Console.WriteLine("\nПроизведение дробей: {0}/{1}", result.numerator, result.denominator);

            SimplifyFraction(ref result);
            Console.WriteLine("Сокращенная дробь: {0}/{1}", result.numerator, result.denominator);

            Console.ReadKey();
        }

        static Fraction MultiplyFractions(Fraction f1, Fraction f2)
        {
            Fraction result;
            result.numerator = f1.numerator * f2.numerator;
            result.denominator = f1.denominator * f2.denominator;
            return result;
        }

        static void SimplifyFraction(ref Fraction fraction)
        {
            int greatestCommonFactor = GCD(fraction.numerator, fraction.denominator);
            fraction.numerator /= greatestCommonFactor;
            fraction.denominator /= greatestCommonFactor;
        }

        static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            return a == 0 ? b : a;
        }
    }
}