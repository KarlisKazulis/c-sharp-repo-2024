using System;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testCase1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            int[] testCase2 = { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };
            int[] testCase3 = { 91, -4, 80, -73, -28 };
            int[] testCase4 = { };

            Console.WriteLine(string.Join(", ", CountPosSumNeg(testCase1)));
            Console.WriteLine(string.Join(", ", CountPosSumNeg(testCase2)));
            Console.WriteLine(string.Join(", ", CountPosSumNeg(testCase3)));
            Console.WriteLine(string.Join(", ", CountPosSumNeg(testCase4)));
        }
        
        public static int[] CountPosSumNeg(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return new int[] { };
            }

            int positiveCount = 0;
            int negativeSumCount = 0;

            foreach (int n in numbers)
            {
                if (n > 0)
                {
                    positiveCount++;
                }
                else if (n < 0)
                {
                    negativeSumCount += n;
                }
            }
            return new int[] { positiveCount, negativeSumCount };
        }
    }
}
