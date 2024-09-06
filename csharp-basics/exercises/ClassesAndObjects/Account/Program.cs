using System;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account mattsAccount = new Account("Matt's account", 1000.0);
            Account myAccount = new Account("My account", 0);
            
            mattsAccount.WithdrawMoney(100.00);
            myAccount.DepositMoney(100.00);

            Console.WriteLine($"{mattsAccount.GetAccountName()}: balance {mattsAccount.GetBalance()}");
            Console.WriteLine($"{myAccount.GetAccountName()}: balance {myAccount.GetBalance()}");

            Account accountA = new Account("A", 100.0);
            Account accountB = new Account("B", 0.0);
            Account accountC = new Account("C", 0.0);

            Account.Transfer(accountA, accountB,50.0);
            Account.Transfer(accountB, accountC, 25.0);

            Console.WriteLine($"{accountA.GetAccountName()}: balance {accountA.GetBalance()}");
            Console.WriteLine($"{accountB.GetAccountName()}: balance {accountB.GetBalance()}");
            Console.WriteLine($"{accountC.GetAccountName()}: balance {accountC.GetBalance()}");
        }
    }
}
