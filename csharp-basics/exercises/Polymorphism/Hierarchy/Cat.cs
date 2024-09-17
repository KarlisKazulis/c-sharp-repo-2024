using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Cat : Feline
    {
        public string Breed { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("meowwwwwwwwwww");
        }

        public override void Eat(Food food)
        {
            FoodEaten += food.Quantity;
        } 
        
        public override string ToString()
        {
            return $"Cat[{Name},  {Breed}, {Weight:F1}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
