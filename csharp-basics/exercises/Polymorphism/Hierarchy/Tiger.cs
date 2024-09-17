using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Tiger : Feline
    {
        public override void MakeSound()
        {
            Console.WriteLine("rawr");
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} is not eating that type of food");
            }
        }

        public override string ToString()
        {
            return $"Tiger[{Name}, {Weight:F1}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
