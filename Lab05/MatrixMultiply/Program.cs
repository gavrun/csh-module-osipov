namespace MatrixMultiply
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];

            // debug
            //a[0, 0] = 1; a[0, 1] = 2; a[1, 0] = 3; a[1, 1] = 4;
            //b[0, 0] = 5; b[0, 1] = 6; b[1, 0] = 7; b[1, 1] = 8;

            Console.WriteLine("Enter values for A matrix");
            Input(a);
            Console.WriteLine();

            Console.WriteLine("Enter values for A matrix");
            Input(b);
            Console.WriteLine();

            // refactored
            int[,] result = Multiply(a, b);

            Output(result);
        }

        private static void Input(int[,] dst)
        {
            for (int i = 0; i < dst.GetLength(0); i++)
            {
                for (int j = 0; j < dst.GetLength(1); j++)
                {
                    Console.Write("Enter value for [{0},{1}] : ", i, j);
                    dst[i,j] += int.Parse(Console.ReadLine());
                }
            }
        }

        private static int[,] Multiply(int[,] a, int[,] b)
        {
            int[,] result = new int[2, 2];

            //result[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0];
            //result[0, 1] = a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1];
            //result[1, 0] = a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0];
            //result[1, 1] = a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1];

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] += a[i, 0] * b[0, j] + a[i, 1] * b[1, j];
                }
            }

            return result;
        }

        private static void Output(int[,] result)
        {
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.WriteLine("{0} ", result[i, j]);
                }
            }
        }
    }
}
