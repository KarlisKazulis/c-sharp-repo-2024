using System;

namespace Exercise5
{
    public class Hoarding : Advert
    {
        private int _rate;
        private int _days;
        private bool _isPrimeLocation;

        public Hoarding(int fee, int rate, int days, bool isPrimeLocation) : base(fee)
        {
            _rate = rate;
            _days = days;
            _isPrimeLocation = isPrimeLocation;
        }

        public override int Cost()
        {
            int baseCost = base.Cost() + _rate * _days;
            if (_isPrimeLocation)
            {
                baseCost = (int)(baseCost * 1.5);
            }

            return baseCost;
        }

        public override string ToString()
        {
            return $"Hoarding cost: {Cost()}";
        }
    }
}
