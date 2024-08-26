using System;

namespace Exercise2
{
    class Program
    {       
        private static void Main(string[] args)
        {
            var sum = 0;

            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());

            int arraySize = maxNumber - minNumber + 1;
            int[] arrayNumbers = new int[arraySize];

            int i = 0;
            while (i < arraySize)
            {
                arrayNumbers[i] = minNumber + i;
                sum += arrayNumbers[i];
                i++;
            }

            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}
