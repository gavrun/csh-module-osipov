namespace WhatDay1
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
        December
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Collections.ICollection DaysInMonths = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            while (true)
            {
                Console.Write("Please enter a day number between 1 and 365: ");
                //Console.WriteLine("Please enter a day number between 1 and 365: ");

                int dayNum = int.Parse(Console.ReadLine());

                int monthNum = 0;

                if (dayNum <= 31) // January
                {
                    goto End;
                }
                else
                {
                    dayNum -= 31;
                    monthNum++;
                }

                if (dayNum <= 28) // February
                {
                    goto End;
                }
                else
                {
                    dayNum -= 28;
                    monthNum++;
                }

                if (dayNum <= 31) // March
                {
                    goto End;
                }
                else
                {
                    dayNum -= 31;
                    monthNum++;
                }

                if (dayNum <= 30) // April
                {
                    goto End;
                }
                else
                {
                    dayNum -= 30;
                    monthNum++;
                }

                if (dayNum <= 31) // May
                {
                    goto End;
                }
                else
                {
                    dayNum -= 31;
                    monthNum++;
                }

                if (dayNum <= 30) // June
                {
                    goto End;
                }
                else
                {
                    dayNum -= 30;
                    monthNum++;
                }

                if (dayNum <= 31) // July
                {
                    goto End;
                }
                else
                {
                    dayNum -= 31;
                    monthNum++;
                }

                if (dayNum <= 31) // August
                {
                    goto End;
                }
                else
                {
                    dayNum -= 31;
                    monthNum++;
                }

                if (dayNum <= 30) // September
                {
                    goto End;
                }
                else
                {
                    dayNum -= 30;
                    monthNum++;
                }

                if (dayNum <= 31) // October
                {
                    goto End;
                }
                else
                {
                    dayNum -= 31;
                    monthNum++;
                }

                if (dayNum <= 30) // November
                {
                    goto End;
                }
                else
                {
                    dayNum -= 30;
                    monthNum++;
                }

                if (dayNum <= 31) // December
                {
                    goto End;
                }
                else
                {
                    dayNum -= 31;
                    monthNum++;
                }

                End:

                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();

                //switch (monthNum)
                //{
                //    case 0: //1
                //        monthName = "January"; break;
                //    case 1: //2
                //        monthName = "February"; break;
                //    case 2: //3
                //        monthName = "March"; break;
                //    case 3: //4
                //        monthName = "April"; break;
                //    case 4: //5
                //        monthName = "May"; break;
                //    case 5: //6
                //        monthName = "June"; break;
                //    case 6: //7
                //        monthName = "July"; break;
                //    case 7: //8
                //        monthName = "August"; break;
                //    case 8: //9
                //        monthName = "September"; break;
                //    case 9: //10
                //        monthName = "October"; break;
                //    case 10: //11
                //        monthName = "November"; break;
                //    case 11: //12
                //        monthName = "December"; break;
                //    default:
                //        monthName = "not done yet"; break;
                //}

                Console.Write("{0} day of the year is ", dayNum, monthName);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{1} {0}", dayNum, monthName);
                Console.ResetColor();
            }
        }
    }
}
