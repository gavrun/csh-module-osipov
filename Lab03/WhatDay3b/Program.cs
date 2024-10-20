namespace WhatDay3b
{
    enum MonthName
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December/*,
        Error*/
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ICollection DaysInMonths = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            System.Collections.ICollection DaysInLeapMonths = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            while (true)
            {
                try
                {
                    Console.Write("Please enter a year number: ");
                    int yearNum = int.Parse(Console.ReadLine());

                    bool isLeapYear = (yearNum % 4 == 0) && (yearNum % 100 != 0 || yearNum % 100 == 0);
                    int maxDayNum = isLeapYear ? 366 : 365;

                    if (isLeapYear)
                    {
                        Console.Write("{0} year ", yearNum);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("IS a leap year");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("{0} year ", yearNum);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("NOT a leap year");
                        Console.ResetColor();
                    }

                    Console.Write("Please enter a day number between 1 and {0}: ", maxDayNum);
                    int dayNum = int.Parse(Console.ReadLine());

                    if (dayNum < 1 || dayNum > maxDayNum)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        throw new ArgumentOutOfRangeException("Day out of range");
                    }

                    // FIXED IT !
                    int originalDayNum = dayNum;

                    int monthNum = 0;

                    if (isLeapYear)
                    {
                        foreach (int daysInMonth in DaysInLeapMonths)
                        {
                            if (dayNum <= daysInMonth)
                            {
                                break;
                            }
                            else
                            {
                                dayNum -= daysInMonth;
                                monthNum++;
                            }
                        }
                    }
                    else
                    {
                        foreach (int daysInMonth in DaysInMonths)
                        {
                            if (dayNum <= daysInMonth)
                            {
                                break;
                            }
                            else
                            {
                                dayNum -= daysInMonth;
                                monthNum++;
                            }
                        }
                    }

                    //foreach (int daysInMonth in DaysInMonths)
                    //{
                    //    if (dayNum <= daysInMonth)
                    //    {
                    //        break;
                    //    }
                    //    else
                    //    {
                    //        dayNum -= daysInMonth;
                    //        monthNum++;
                    //    }
                    //}

                    MonthName temp = (MonthName)monthNum;
                    string monthName = temp.ToString();

                    Console.Write("{0} day of the year is ", originalDayNum/*, monthName*/);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("{1} {0}", dayNum, monthName);
                    Console.ResetColor();

                    // Continue input
                    Console.WriteLine("Check another year and day? (y/n)");
                    string response = Console.ReadLine().ToLower();

                    if (response != "y" && response != "n")
                    {
                        Console.WriteLine("Invalid input. Please enter 'y' or 'n' next time.");
                        break;
                    }
                    else if (response == "n")
                    {
                        break;
                    }
                }
                catch (Exception caught)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(caught);

                    throw;
                }
            }
        }
    }
}
