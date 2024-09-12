using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class TVCommercial : Advert
    {
        private int _seconds;
        private double _costPerSecond;
        private bool _isPeakTime;

        public TVCommercial(int fee, int seconds, double costPerSecond, bool isPeakTime)
            : base(fee)
        {
            _seconds = seconds;
            _costPerSecond = costPerSecond;
            _isPeakTime = isPeakTime;
        }

        public override int Cost()
        {
            var totalCost = base.Cost() + (_costPerSecond * _seconds);
            if (_isPeakTime)
            {
                totalCost *= 2;
            }

            return (int)totalCost;
        }

        public override string ToString()
        {
            return $"Commercial cost: {Cost()}";
        }
    }
}
