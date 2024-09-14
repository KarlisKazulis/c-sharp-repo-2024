using System;
using System.Collections.Generic;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> colors = new List<string>();
            colors.Add("purple");
            colors.Add("black");
            colors.Add("blue");
            colors.Add("orange");
            colors.Add("white");

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
