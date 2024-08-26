using System;

namespace TenBillion
{
    class Program
    {
        //TODO Write a C# program that reads an positive integer (if it is negative, make it positive) and count the number of digits the number (less than ten billion) has.
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            var input = long.Parse(Console.ReadLine());

            if (input > 1000000000)
            {
                Console.WriteLine("You entered a number larger than 10 billion");
                return;
            }

            input = Math.Abs(input); // turns negative number into positive 

            int countDigits = input.ToString().Length;

            Console.WriteLine("The number " + input + " has " + countDigits + " digits");


        }
    }
}
