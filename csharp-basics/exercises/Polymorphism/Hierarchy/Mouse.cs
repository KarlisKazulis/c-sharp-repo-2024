using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Squeak");
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable)
            {
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} are not eating that type of food.");
            }
        }
    }
}
