using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    public class Commission : Hourly
    {
        private double _totalSalesMade;
        private double _commissionRate;

        public Commission(string eName, string eAdress, string ePhone, string socSecNumber, double rate,
            double commissionRate) : base(eName, eAdress, ePhone, socSecNumber, rate)
        {
            _totalSalesMade = 0;
            _commissionRate = commissionRate;
        }

        public void AddSales(double totalSales)
        {
            _totalSalesMade += totalSales;
        }

        public override double Pay()
        {
            var payment = base.Pay();
            payment += _totalSalesMade * _commissionRate;
            _totalSalesMade = 0;
            return payment;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += " Total sales: " + _totalSalesMade;
            return result;
        }
    }
}
