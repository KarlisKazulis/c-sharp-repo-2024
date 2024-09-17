namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FuelGauge fuelGauge = new FuelGauge();
            Odometer odometer = new Odometer(fuelGauge);

            for(int i = 0; i < 70; i++)
            {
                fuelGauge.AddFuel();
            }

            while(fuelGauge.GetCurrentFuelLevel() > 0)
            {
                odometer.IncreaseMileage();
                Console.WriteLine($"Current mileage: {odometer.GetCurrentMileage()} km, " +
                    $"Fuel level: {fuelGauge.GetCurrentFuelLevel()} liters");
            }

            Console.WriteLine("You are out of fuel!");
        }
    }
}
