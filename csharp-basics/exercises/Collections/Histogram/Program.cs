using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../../midtermscores.txt";

        private static void Main(string[] args)
        {

            var scores = File.ReadAllLines(Path)
                .SelectMany(line => line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries))
                .Select(int.Parse)
                .ToList();

            var scoreHistogram = HistogramCalculation(scores);

            HistogramDisplay(scoreHistogram);
        }

        private static List<int> HistogramCalculation(List<int> scores)
        {
            var histogram = new List<int>(new int[11]);

            foreach (var score in scores)
            {
                if (score >= 0 && score <= 100)
                {
                    int scoreIndex = (score == 100) ? 10 : score / 10;
                    histogram[scoreIndex]++;
                }
            }

            return histogram;
        }

        private static void HistogramDisplay(List<int> histogram)
        {
            string[] scoreRange =
            {
                "00-09:",
                "10-19:",
                "20-29:",
                "30-39:",
                "40-49:",
                "50-59:",
                "60-69:",
                "70-79:",
                "80-89:",
                "90-99:",
                "100:"
            };

            for (int i = 0; i < histogram.Count; i++)
            {
                Console.WriteLine($"{scoreRange[i]}  {new string('*', histogram[i]) }");
            }
        }
    }
}
