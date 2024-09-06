using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../../../flights.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            var flightPairs = readText
                .Select(pair =>
                    new KeyValuePair<string, string>(pair.Split(" ->")[0], pair.Split(" -> ")[1]))
                .ToList();
            var flightDictionary = new Dictionary<string, List<string>>();
            foreach (var pair in flightPairs)
            {
                if (flightDictionary.ContainsKey(pair.Key))
                {
                    flightDictionary[pair.Key].Add(pair.Value);
                }
                else
                {
                    flightDictionary[pair.Key] = new List<string> { pair.Value };
                }
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }

            Console.WriteLine("Pick a starting point");
            var number = 1;
            foreach (var startingPoint in flightDictionary)
            {
                Console.WriteLine($"{number} {startingPoint.Key}");
                number++;
            }

            var userInput = Console.ReadLine();

            var startingPointPosition = int.Parse(userInput);
            var firstFlight = string.Empty;
            number = 1;
            foreach (var startingPoint in flightDictionary)
            {
                if (startingPointPosition == number)
                {
                    firstFlight = startingPoint.Key;
                }
                number++;
            }
            
            Console.WriteLine("pick destination");

            number = 1;
            foreach (var destination in flightDictionary[firstFlight])
            {
                Console.WriteLine($"{number} {destination}");
                number++;
            }

            userInput = Console.ReadLine();
            startingPointPosition = int.Parse(userInput);
            var firstDestination = string.Empty;
            number = 1;

            foreach (var startingPoint in flightDictionary)
            {
                if (startingPointPosition == number)
                {
                    firstFlight = startingPoint.Key;
                }
                number++;
            }
        }
    }
}
