﻿namespace WhatDay3
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
            // All months days collection
            System.Collections.ICollection DaysInMonths = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            while (true)
            {
                try
                {
                    Console.Write("Please enter a year number: ");
                    int yearNum = int.Parse(Console.ReadLine());

                    bool isLeapYear = (yearNum % 4 == 0) && (yearNum % 100 != 0 || yearNum % 100 == 0);

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

                    Console.Write("Please enter a day number between 1 and 365: ");
                    int dayNum = int.Parse(Console.ReadLine());

                    if (dayNum < 1 || dayNum > 365)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        throw new ArgumentOutOfRangeException("Day out of range");
                    }

                    // FIXED IT !
                    int originalDayNum = dayNum;

                    int monthNum = 0;

                    foreach (int daysInMonth in DaysInMonths)
                    {
                        if (dayNum <= daysInMonth) // All months sequence
                        {
                            break;
                        }
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }

                    MonthName temp = (MonthName)monthNum;
                    string monthName = temp.ToString();

                    Console.Write("{0} day of the year is ", originalDayNum/*, monthName*/);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("{1} {0}", dayNum, monthName);
                    Console.ResetColor();

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
