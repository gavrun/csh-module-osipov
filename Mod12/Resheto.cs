﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Resheto
{
    class Program
    { static string resultText;
        static void Main(string[] args)
        {
            string MaxValue = Console.ReadLine();

            int maxValue = 0;
            //    System.Text.StringBuilder resultText = new System.Text.StringBuilder();
           
            if (int.TryParse(MaxValue, out maxValue))
            {
                for (int trial = 2; trial <= maxValue; trial++)
                {
                    bool isPrime = true;
                    for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                    {
                        if (trial % divisor == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        resultText += trial;
                       // resultText.AppendFormat("{0} ", trial);
                    }
                }
            }
            else
            {
                resultText = "Error";
               // resultText.Append("Unable to parse maximum value.");
            }

            Console.WriteLine(resultText.ToString());
            Console.ReadLine();
        }
    }
}
