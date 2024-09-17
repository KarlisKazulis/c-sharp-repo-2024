using System;
using System.Collections.Generic;

namespace ListExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            bool containsWord = colors.Contains("White");
            if (containsWord)
            {
                Console.WriteLine("List contains word 'White'");
            }
            else
            {
                Console.WriteLine("List does not contain word 'White'");
            }
        }
    }
}
