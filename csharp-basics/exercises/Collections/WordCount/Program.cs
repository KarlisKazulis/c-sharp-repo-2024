using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Reflection.Metadata;

namespace WordCount
{
    class Program
    {
        private const string Path = "../../../lear.txt";
        static void Main(string[] args)
        {
            string fileContent = File.ReadAllText(Path);

            int lineCount = 0;
            int wordCount = 0;
            int charCount = 0;

            foreach (var line in File.ReadAllLines(Path))
            {
                lineCount++;
                charCount += line.Length;

                List<string> words = new List<string>();

                var split = line.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                words.AddRange(split);

                wordCount += words.Count;
            }

            Console.WriteLine(lineCount);
            Console.WriteLine(wordCount);
            Console.WriteLine(charCount);
        }
    }
}
