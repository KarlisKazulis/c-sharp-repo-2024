using System;
using System.Linq;

namespace ReplaceSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };
            
            var updatedWords = words.Select(w => w.Replace("ea", "*")).ToList();
            updatedWords.ForEach(w => Console.WriteLine(w));
        }
    }
}
