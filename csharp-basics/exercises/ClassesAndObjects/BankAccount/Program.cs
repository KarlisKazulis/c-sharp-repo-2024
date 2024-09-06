using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount benbenPositive = new BankAccount("Benson", 17.25);
            Console.WriteLine(benbenPositive.ShowUserNameAndBalance());


            BankAccount benbenNegative = new BankAccount("Benson", -17.5);
            Console.WriteLine(benbenNegative.ShowUserNameAndBalance());
        }
    } 
    
    public class BankAccount
    {
        private string _name;
        private double _balance;

        public BankAccount(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }

        public string ShowUserNameAndBalance()
        {
            string correctedBalance;

            if (_balance < 0)
            {
                correctedBalance = "-$" + Math.Abs(_balance).ToString("0.00");
            }
            else
            {
                correctedBalance = "$" + _balance.ToString("0.00");
            }

            return $"{_name}, {correctedBalance}";
        }
    }
}
