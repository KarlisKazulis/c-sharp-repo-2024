using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace DragRace
{
    class Program
    {
        /**
 * Take a look at the cars in this solution.
 * 1. Extract common behaviour to an interface called Car, and use it in the all classes.
 * Which methods will be extracted with an empty body, and which can be default?
 * 2. Create two more cars of your own choice.
 * 3. As you see there is a possibility to use some kind of boost in Lexus, extract it to a new interface
          and add that behaviour in one more car.
 * 4. Create one instance of an each car and add them to list.
 * 5. Iterate over the list 10 times, in the 3rd iteration use speed boost on the car if they have one.
 * 6. Print out the car name and speed of the fastest car
 */

        private static void Main(string[] args)
        {
            var cars = new List<ICar>();
            cars.Add(new Lada());
            cars.Add(new Volvo());
            cars.Add(new Tesla());
            cars.Add(new Lexus());
            cars.Add(new Bmw());
            cars.Add(new Audi());

            cars.ForEach(car => car.StartEngine());

            for (int i = 0; i < 10; i++)
            {
                foreach (var car in cars)
                {
                    car.SpeedUp();
                }

                if (i == 2)
                {
                    foreach (var car in cars)
                    {
                        if (car is IBoostable boostableCar)
                        {
                            boostableCar.UseNitrousOxideEngine();
                        }
                    }
                }
            }

            ICar fastestCar = cars[0];
            foreach (var car in cars)
            {
                if (int.Parse(car.ShowCurrentSpeed()) > int.Parse(fastestCar.ShowCurrentSpeed()))
                {
                    fastestCar = car;
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.GetType().Name}: {car.ShowCurrentSpeed()} km/h");
            }

            Console.WriteLine($"The fastest car is {fastestCar.GetType().Name} and the speed is {fastestCar.ShowCurrentSpeed()} km/h");
        }
    }
}