using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var values = new List<string> { "Hi", "Meow", "Hello", "Meow", "Hi!", "Meow", "Hi", "Bye" };

            var valuesWithoutDuplicates = values
                .GroupBy(n => n)
                .Where(g => g.Count() == 1)
                .Select(g => g.Key)
                .ToList();

            Console.WriteLine(string.Join(", ", valuesWithoutDuplicates));
        }
    }
}
