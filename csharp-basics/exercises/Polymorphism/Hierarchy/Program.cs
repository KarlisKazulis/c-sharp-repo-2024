using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var animals = new List<Animal>();

            while (true)
            {
                var animalInput = Console.ReadLine();
                if (animalInput == "End")
                {
                    break;
                }
                
                var foodInput = Console.ReadLine();
                Animal animal = CreateAnimal(animalInput);
                if (animal == null)
                {
                    continue;
                }

                animal.MakeSound();

                Food food =  CreateFood(foodInput);
                animal.Eat(food);
                animals.Add(animal);

                Console.WriteLine(animal);
            }

            Console.WriteLine();
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        static Animal CreateAnimal(string input)
        {
            var details = input.Split(' ');
            switch (details[0])
            {
                case "Cat":
                    return new Cat
                    {
                        Name = details[1],
                        Weight = double.Parse(details[2]),
                        LivingRegion = details[3],
                        Breed = details[4]
                    };
                case "Tiger":
                    return new Tiger
                    {
                        Name = details[1],
                        Weight = double.Parse(details[2]),
                        LivingRegion = details[3]
                    };
                case "Mouse":
                    return new Mouse
                    {
                        Name = details[1],
                        Weight = double.Parse(details[2]),
                        LivingRegion = details[3]
                    };
                case "Zebra":
                    return new Zebra
                    {
                        Name = details[1],
                        Weight = double.Parse(details[2]),
                        LivingRegion = details[3]
                    };
                default:
                    return null;
            }
        }

        static Food CreateFood(string input)
        {
            var details = input.Split(' ');
            string foodName = details[0];
            int foodQuantity = int.Parse(details[1]);

            return foodName == "Vegetable"
                ? new Vegetable { Quantity = foodQuantity}
                : new Meat { Quantity = foodQuantity };
        }
    }
}