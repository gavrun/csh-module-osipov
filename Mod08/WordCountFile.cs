using System;
using System.IO;
using System.Text.RegularExpressions;

namespace WordCount
{
    public class WordCount
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
   }

    public class WordCount2
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
    }   

    
    class Program
    {
        static void Main(string[] args)
        {
            WordCount wd = new WordCount("test.txt");
            Console.WriteLine(wd.Count);

            WordCount2 wd2 = new WordCount2("test.txt");
            Console.WriteLine(wd2.Count);
        }
    }
}
