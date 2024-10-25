namespace ArrayMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // define array size
            Console.WriteLine("Enter array size:");
            int n = int.Parse(Console.ReadLine());

            // create array
            int[] arr = new int[n];

            // populate array
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Index [{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            // define data methods
            Console.WriteLine("Various math operations with elements of this array:");

            // output data methods
            Console.WriteLine($"1. Sum of all array elements: {CalculateSum(arr)}");

            Console.WriteLine($"2. Average of all array elements: {CalculateAverage(arr):F2}");

            Console.WriteLine($"3. Sum of positive elements: {CalculatePositiveSum(arr)}");
            Console.WriteLine($"3. Sum of negative elements: {CalculateNegativeSum(arr)}");

            int sumEvenIndex = CalculateEvenIndexSum(arr);
            int sumOddIndex = CalculateOddIndexSum(arr);
            Console.WriteLine($"4. Sum of elements at even indices: {sumEvenIndex}");
            Console.WriteLine($"4. Sum of elements at odd indices: {sumOddIndex}");

            int maxValue = FindMaxValue(arr);
            int maxIndex = FindMaxIndex(arr);
            int minValue = FindMinValue(arr);
            int minIndex = FindMinIndex(arr);
            Console.WriteLine($"5. Maximum element: {maxValue}, index: {maxIndex}");
            Console.WriteLine($"5. Minimum element: {minValue}, index: {minIndex}");

            Console.WriteLine($"6. Product of elements between max and min elements: {CalculateProductBetweenMinMax(arr, maxIndex, minIndex)}");

            // sum of all elements in array
            static int CalculateSum(int[] arr)
            {
                int sum = 0;
                foreach (int value in arr)
                {
                    sum += value;
                }
                return sum;
            }

            // average of array
            static double CalculateAverage(int[] arr)
            {
                int sum = CalculateSum(arr);
                return (double)sum / arr.Length;
            }

            // sum of positive and negative elements of array

            static int CalculatePositiveSum(int[] arr)
            {
                int sum = 0;
                foreach (int value in arr)
                {
                    if (value > 0) sum += value;
                }
                return sum;
            }

            static int CalculateNegativeSum(int[] arr)
            {
                int sum = 0;
                foreach (int value in arr)
                {
                    if (value < 0) sum += value;
                }
                return sum;
            }

            // sum of elements at odd and even indices

            static int CalculateEvenIndexSum(int[] arr)
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i += 2)
                {
                    sum += arr[i];
                }
                return sum;
            }

            static int CalculateOddIndexSum(int[] arr)
            {
                int sum = 0;
                for (int i = 1; i < arr.Length; i += 2)
                {
                    sum += arr[i];
                }
                return sum;
            }

            // maximum and minimum elements and their indices

            static int FindMaxValue(int[] arr)
            {
                int max = arr[0];
                foreach (int value in arr)
                {
                    if (value > max)
                        max = value;
                }
                return max;
            }

            static int FindMaxIndex(int[] arr)
            {
                int max = 0;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > arr[max])
                        max = i;
                }
                return max;
            }

            static int FindMinValue(int[] arr)
            {
                int min = arr[0];
                foreach (int value in arr)
                {
                    if (value < min)
                        min = value;
                }
                return min;
            }

            static int FindMinIndex(int[] arr)
            {
                int min = 0;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < arr[min])
                        min = i;
                }
                return min;
            }

            // product(multiplication) of elements between the maximum and minimum elements and swapped
            static int CalculateProductBetweenMinMax(int[] arr, int maxIndex, int minIndex)
            {
                if (Math.Abs(maxIndex - minIndex) <= 1)
                {
                    return 1; // neighbors 
                }

                int product = 1;

                int start = Math.Min(maxIndex, minIndex) + 1;
                int end = Math.Max(maxIndex, minIndex);

                for (int i = start; i < end; i++)
                {
                    product += arr[i];
                }

                return product;
            }
        }
    }
}
