using System;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
            double energyDrinkDrinkers = CalculateEnergyDrinkers(NumberedSurveyed);
            double usersPreferCitrus = CalculatePreferCitrus(energyDrinkDrinkers);

            int energyDrinkDrinkersInt = (int)Math.Round(energyDrinkDrinkers);
            int usersPreferCitrusInt = (int) Math.Round(usersPreferCitrus);

            Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
            Console.WriteLine("Approximately " + energyDrinkDrinkersInt + " bought at least one energy drink");
            Console.WriteLine(usersPreferCitrusInt + " of those " + "prefer citrus flavored energy drinks.");
        } 
        
        static double CalculateEnergyDrinkers(int numberSurveyed)
        {
            return numberSurveyed * PurchasedEnergyDrinks;
        }

        static double CalculatePreferCitrus(double energyDrinkDrinkers)
        {
            return energyDrinkDrinkers * PreferCitrusDrinks;
        }
    }
}
