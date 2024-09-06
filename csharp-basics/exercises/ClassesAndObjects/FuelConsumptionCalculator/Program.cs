using System;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Car car1 = ConstructCar("Volvo");
            Car car2 = ConstructCar("Opel");

            CarConsumptionDetails(car1, "Volvo");
            CarConsumptionDetails(car2, "Opel");
        }

        static Car ConstructCar(string carName)
        {
            Console.WriteLine($"What was the odometer reading before driving {carName} ?");
            double startOdo = double.Parse(Console.ReadLine());

            Car car = new Car(startOdo);

            Console.WriteLine($"What was the odometer reading after driving" +
                              $" and how many liters of fuel were consumed for {carName} ?");

            int mileage = int.Parse(Console.ReadLine());
            double liters = double.Parse(Console.ReadLine());

            car.FillUp(mileage, liters);

            return car;
        }

        static void CarConsumptionDetails(Car car, string carName)
        {
            double consumption = car.CalculateConsumption();
            Console.WriteLine($"{carName} fuel consumption was {consumption:F2} liters per 100 km");

            if (car.IsGasHog())
            {
                Console.WriteLine($"{carName} is a gas hog.");
            }
            else if (car.IsEconomyCar())
            {
                Console.WriteLine($"{carName} is an economy car.");
            }
            else
            {
                Console.WriteLine($"{carName} has normal fuel consumption.");
            }
        }
    }
}
