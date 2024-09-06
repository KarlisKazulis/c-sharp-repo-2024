using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace Account
{
    class Account
    {
        private string _accountName;
        private double _accountBalance;

        public Account(string name, double initialBalance)
        {
            _accountName = name;
            _accountBalance = initialBalance;
        }

        public void DepositMoney(double amount)
        {
            if (amount > 0)
            {
                _accountBalance += amount;
            }
        }

        public bool WithdrawMoney(double amount)
        {
            if (amount > 0 && amount <= _accountBalance)
            {
                _accountBalance -= amount;
                return true;
            }

            return false;
        } 
        
        public double GetBalance()
        {
            return _accountBalance;
        }

        public string GetAccountName()
        {
            return _accountName;
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            if (howMuch > 0 && from._accountBalance >= howMuch )
            {
                from.WithdrawMoney(howMuch);
                to.DepositMoney(howMuch);
            }
        }
    }
}
