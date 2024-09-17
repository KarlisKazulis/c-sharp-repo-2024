using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    internal class Car
    {
        private double _startKilometers;
        private double _endKilometers;
        private double _liters;

        public Car(double startOdo)
        {
            _startKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            double distance = _endKilometers - _startKilometers;
            double consumption = (_liters / distance) * 100;
            return consumption;
        }

        public bool IsGasHog()
        {
            bool value = false;

            if (CalculateConsumption() > 15)
            {
                value = true;
            }

            return value;
        }

        public bool IsEconomyCar()
        {
            bool value = false;

            if (CalculateConsumption() < 5)
            {
                value = true;
            }

            return value;
        }

        public void FillUp(int mileage, double liters)
        {
            _endKilometers = mileage;
            _liters = liters;
        }
    }
}
