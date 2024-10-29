using System;
using System.IO;

namespace CopyFileUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare strings and streams
            string sFrom, sTo;
            StreamReader srFrom;
            StreamWriter swTo;

            // prompt for input file name
            Console.Write("Copy from: ");
            sFrom = Console.ReadLine();

            // prompt for output file name
            Console.Write("Copy to: ");
            sTo = Console.ReadLine();

            Console.WriteLine("Copy from {0} to {1}", sFrom, sTo);

            try
            {
                // instantiate streams

                // open input file for reading
                srFrom = new StreamReader(sFrom);

                // open output file for writing
                swTo = new StreamWriter(sTo);

                // read each line, convert to uppercase, and write to output
                while (srFrom.Peek() != -1)
                {
                    string sBuffer = srFrom.ReadLine();
                    sBuffer = sBuffer.ToUpper();
                    swTo.WriteLine(sBuffer);
                }

                // close both streams
                swTo.Close();
                srFrom.Close();
            } catch (FileNotFoundException)
            {
                // handle input file is not found
                Console.WriteLine("Input file not found");
            } catch (Exception e)
            {
                // handle any other exceptions
                Console.WriteLine("Unexpected exception");
                Console.WriteLine(e.ToString());
            }
        }
    }
}
