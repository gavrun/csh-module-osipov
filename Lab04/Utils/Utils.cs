using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Utils
    {
        public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
            //return a > b ? a : b;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Calculate factorial and return the result as an out parameter
        public static bool Factorial(int n, out int answer)
        {
            int k;
            int f;

            bool ok = true;

            // validate input value
            if (n < 0) ok = false;

            try
            {
                checked
                {
                    //factorial value
                    f = 1;
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception)
            {
                f = 0;
                ok = false;
            }
            answer = f;

            return ok;
        }
    }
}
