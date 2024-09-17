using System;
using System.Collections.Generic;
using System.Drawing;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<string>();

            cars.Add("Volvo");
            cars.Add("BMW");
            cars.Add("Mercedes");
            cars.Add("Nissan");
            cars.Add("Honda");
            cars.Add("Kia");
            cars.Add("Audi");
            cars.Add("Tesla");
            cars.Add("Mitsubishi");
            cars.Add("Saab");

            cars.Insert(4, "Pagani");
            
            var lastPosition = cars.Count - 1;
            cars[lastPosition] = "Porsche";
         
            cars.Sort();

            bool containsWord = cars.Contains("Foobar");
            if (containsWord)
            {
                Console.WriteLine("List contains the word 'Foobar'");
            }
            else
            {
                Console.WriteLine("List does not contain the word 'Foobar'.");
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car + " ");
            }
        }
    }
}
