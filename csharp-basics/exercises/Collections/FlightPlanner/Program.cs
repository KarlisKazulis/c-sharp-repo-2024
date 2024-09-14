using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../../../flights.txt";

        private static void Main(string[] args)
        {
            var flightDictionary = ExtractFlightsToDictionary();
            var flightPath = new List<string>();
            Console.WriteLine("Pick a starting point");
            ShowAvailableCities(flightDictionary.Keys.ToList());

            var userInput = Console.ReadLine();
            var startingPointPosition = int.Parse(userInput);

            var firstFlight = GetUserChoiceValue(flightDictionary.Keys.ToList(), startingPointPosition);
            flightPath.Add(firstFlight);
            var destination = string.Empty;
            var firstTime = true;

            while (firstFlight != destination)
            {
                Console.WriteLine("Pick a destination");
                var key = firstTime ? firstFlight : destination;
                ShowAvailableCities(flightDictionary[key]);

                userInput = Console.ReadLine();
                startingPointPosition = int.Parse(userInput);

                destination = GetUserChoiceValue(flightDictionary[key], startingPointPosition);
                flightPath.Add(destination);
                firstTime = false;
            }
        }

        private static string GetUserChoiceValue(List<string> flights, int startingPointPosition)
        {
            var number = 1;
            var flight = string.Empty;
            foreach (var startingPoint in flights)
            {
                if (startingPointPosition == number)
                {
                    flight = startingPoint;
                }
                number++;
            }

            return flight;
        }

        private static void ShowAvailableCities(List<string> flights)
        {
            var number = 1;
            foreach (var startingPoint in flights)
            {
                Console.WriteLine($"{number} {startingPoint}");
                number++;
            }
        }

        private static Dictionary<string, List<string>> ExtractFlightsToDictionary()
        {
            var readText = File.ReadAllLines(Path);
            var flightPairs = readText
                .Select(pair =>
                    new KeyValuePair<string, string>(pair.Split(" -> ")[0], pair.Split(" -> ")[1]))
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
            }

            return flightDictionary;
        }
    }
}
