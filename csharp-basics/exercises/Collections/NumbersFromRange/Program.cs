using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace NumbersFromRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var numbers = new List<int>();
            while (numbers.Count() < 10)
            {
                numbers.Add(random.Next(1, 100));
            }

            var sortedList = numbers.Where(n => n > 30 && n < 100).ToList();
           
            foreach (int number in sortedList)
            {
                Console.WriteLine(number);
            }
        }
    }
}
