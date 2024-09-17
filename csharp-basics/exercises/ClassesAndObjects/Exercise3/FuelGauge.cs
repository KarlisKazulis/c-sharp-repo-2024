using System;

namespace Exercise3
{
    internal class FuelGauge
    {
        private int _fuelLevel;
        private const int _maxFuel = 70;

        public FuelGauge()
        {
            _fuelLevel = 0;
        }

        public int GetCurrentFuelLevel()
        {
            return _fuelLevel;
        }

        public void AddFuel()
        {
            if (_fuelLevel < _maxFuel)
            {
                _fuelLevel++;
            }
            else
            {
                Console.WriteLine("Tank is full!");
            }
        } 
        
        public void UseGas()
        {
            if (_fuelLevel > 0)
            {
                _fuelLevel--;
            }
            else
            {
                Console.WriteLine("Out of fuel!");
            }
        }
    }
}
