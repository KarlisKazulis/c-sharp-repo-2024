using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string AnimalType { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }
        public string LivingRegion { get; set; }

        public abstract void MakeSound();
        public abstract void Eat(Food food);

        public override string ToString()
        {
            return $"{GetType().Name}[{Name}, {Weight:F1}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
