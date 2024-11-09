using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PassingRefByRef
{
    class PassingRefByRef
    {
        static void Change(ref int[] pArray)
        {
            // Both of the following changes will affect the original variables:
            pArray[0] = 888;
            pArray = new int[5] { -3, -1, -2, -3, -4 };
            System.Console.WriteLine("Inside the method, the last element is: {0}", pArray[pArray.Length - 1]);
        }

        static void Main()
        {
            int[] arr = { 1, 4, 5, 6, 7, 8, 9, 10 };
            System.Console.WriteLine("Inside Main, before calling the method, the last element is: {0}", arr[arr.Length - 1]);

            Change(ref arr);
            System.Console.WriteLine("Inside Main, after calling the method, the last element is: {0}", arr[arr.Length - 1]);
        }
    }

}
