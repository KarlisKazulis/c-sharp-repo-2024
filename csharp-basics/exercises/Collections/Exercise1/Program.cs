using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            List<string> carsList = array.ToList();
            Console.WriteLine("Cars list:");
            Console.WriteLine(string.Join(", ", carsList));

            HashSet<string> carsHashSet = new HashSet<string>(array);
            Console.WriteLine("Cars HashSet:");
            Console.WriteLine(string.Join(", ", carsHashSet));

            var carsDictionary = new Dictionary<string, string>
            {
                { "Audi", "Germany" },
                { "BMW", "Germany" },
                { "Honda", "Japan" },
                { "Mercedes", "Germany" },
                { "Volkswagen", "Germany" },
                { "Tesla", "USA" }
            };
            Console.WriteLine("Cars dictionary:");
            foreach (var car in carsDictionary)
            {
                Console.WriteLine($"{car.Key} - {car.Value}");
            }
        }
    }
}
