// cs_keyword_as.cs
// The as operator.

using System;
class Class1
{
}

class Class2
{
}

class MainClass
{
    static void Main()
    {
        object[] objArray = new object[6];
        objArray[0] = new Class1();
        objArray[1] = new Class2();
        objArray[2] = "hello";
        objArray[3] = 123;
        objArray[4] = 123.4;
        objArray[5] = null;

        for (int i = 0; i < objArray.Length; ++i)
        {
            string s = objArray[i] as string;
            Console.Write("{0}:", i);
            if (s != null)
            {
                Console.WriteLine("'" + s + "'");
            }
            else
            {
                Console.WriteLine("not a string");
            }
        }
    }
}
