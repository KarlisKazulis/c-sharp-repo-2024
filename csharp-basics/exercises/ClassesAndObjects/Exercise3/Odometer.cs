using System;

namespace Exercise3
{
    internal class Odometer
    {
        private int _mileage;
        private FuelGauge _fuelGauge;
        private const int maxMileage = 999999;

        public Odometer(FuelGauge fuelGauge)
        {
            _mileage = 0;
            _fuelGauge = fuelGauge;
        }

        public int GetCurrentMileage()
        {
            return _mileage;
        }

        public void IncreaseMileage()
        {
            if (_fuelGauge.GetCurrentFuelLevel() > 0)
            {
                _mileage++;
                _fuelGauge.UseGas();

                if (_mileage > maxMileage)
                {
                    _mileage = 0;
                }
            }
            else
            {
                Console.WriteLine("You are out of fuel!");
            }
        }
    }
}
