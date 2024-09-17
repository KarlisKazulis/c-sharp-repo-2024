using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    internal class SavingsAccount
    {
        private decimal _balance;
        private decimal _annualInterestRate;

        public SavingsAccount(decimal startingBalance, decimal annualInterestRate)
        {
            _balance = startingBalance;
            _annualInterestRate = annualInterestRate;
        }

        public void DepositMoney(decimal amount)
        {
            _balance += amount;
        }

        public void WithDrawMoney(decimal amount)
        {
            _balance -= amount;
        }

        public void AddMonthlyInterest()
        {
            decimal monthyInterestRate = _annualInterestRate / 12 / 100;
            decimal interest = _balance * monthyInterestRate;
            _balance += interest;
        }

        public decimal GetBalance()
        {
            return _balance;
        }
    }

}
