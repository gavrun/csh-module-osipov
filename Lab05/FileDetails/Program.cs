namespace FileDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // debug length check
            Console.WriteLine("number of args: " + args.Length);
            Console.WriteLine();
            
            string fileName = args[0]; // first argument

            FileStream stream = new FileStream(fileName, FileMode.Open); // open file as stream

            StreamReader reader = new StreamReader(stream); // read file from stream

            int size = (int)stream.Length;
            char[] contents = new char[size]; // array of file size

            for (int i = 0; i < size; i++)
            {
                contents[i] = (char)reader.Read(); // fill in array from stream reader
            }

            //foreach (var arg in args)
            //{
            //    Console.WriteLine(arg); // debug out argument
            //}

            //Console.WriteLine("====== debug print start ======");
            //foreach (char ch in contents)
            //{
            //    Console.Write(ch + " "); // debug out file content
            //}
            //Console.WriteLine();
            //Console.WriteLine("===== debug print finish =====");

            reader.Close();

            Summarize(contents);
        }

        static void Summarize(char[] contents)
        {
            int vowels = 0, consonants = 0, lines = 0;

            foreach (char current in contents)
            {
                if (Char.IsLetter(current))
                {
                    if ("AEIOUaeiou".IndexOf(current) != -1) // run over each index
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
                else if (current == '\n')
                {
                    lines++;
                }
            }

            Console.WriteLine("Total no of characters: {0}", contents.Length);
            Console.WriteLine("Total no of vowels : {0}", vowels);
            Console.WriteLine("Total no of consonants: {0}", consonants);
            Console.WriteLine("Total no of lines : {0}", lines);
        }
    }
}
