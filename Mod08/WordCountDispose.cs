using System;
using System.IO;
using System.Text.RegularExpressions;

namespace WordCount
{
    public class WordCount : IDisposable
    {
    private String filename = String.Empty;
    private int nWords = 0;
    private String pattern = @"\b\w+\b";


    public WordCount(string filename)
    {
        if (!File.Exists(filename))
            throw new FileNotFoundException("The file does not exist.");

        this.filename = filename;
        string txt = String.Empty;

        using (StreamReader sr = new StreamReader(filename))
        {
            txt = sr.ReadToEnd();
            sr.Close();
        }
        nWords = Regex.Matches(txt, pattern).Count;
    }

        public string FullName
        { get { return filename; } }

        public string Name
        { get { return Path.GetFileName(filename); } }

        public int Count
        { get { return nWords; } }

        public void Dispose()
        {
            string output = "The Dispose method. WordCount";
            Console.WriteLine(output);
        }

        ~WordCount()
        {
            string output = "The WordCount finalizer.";
            Console.WriteLine(output);
        }
    }

    public class WordCount2 :IDisposable
    {
        private String filename = String.Empty;
        private int nWords = 0;
        private String pattern = @"\b\w+\b";

        public WordCount2(string filename)
        {
            if (!File.Exists(filename))
                throw new FileNotFoundException("The file does not exist.");

            this.filename = filename;
            string txt = String.Empty;
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(filename);
                txt = sr.ReadToEnd();
                sr.Close();
            }
            catch { }
            finally
            {
                if (sr != null) sr.Dispose();
            }
            nWords = Regex.Matches(txt, pattern).Count;
        }

        public string FullName
        { get { return filename; } }

        public string Name
        { get { return Path.GetFileName(filename); } }

        public int Count
        { get { return nWords; } }

        public void Dispose()
        {
            string output = "The Dispose method. WordCount2";
            Console.WriteLine(output);
        }

        ~WordCount2()
        {
            string output = "The WordCount2 finalizer.";
            Console.WriteLine(output);
        }
    }   

    
    class WordCountDispose
    {
        static void Main(string[] args)
        {
            Test();
            Console.WriteLine("Test");
            Console.ReadLine();
        }

        private static void Test()
        {
            // автоматически вызывается Dispose()
            using (WordCount wd = new WordCount("test.txt"))
            {
            }
			
			//using var wd = new WordCount("test.txt"); // C#8.0

            // автоматически вызывается Dispose()
            WordCount2 wd2 = null;
            try
            {
                wd2 = new WordCount2("test.txt");
            }
            finally
            {
                wd2.Dispose();
            }

            // автоматически НЕ вызывается Dispose()
            WordCount wd1 = new WordCount("test.txt");
            Console.WriteLine(wd1.Count);

            WordCount2 wd21 = new WordCount2("test.txt");
            Console.WriteLine(wd21.Count);
        }
    }
}
