namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much money is in the account?");
            decimal startingBalance = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the annual interest rate: ");
            decimal annualInterestRate = decimal.Parse(Console.ReadLine());

            Console.WriteLine("How long has the account been opened (months)? ");
            int months = int.Parse(Console.ReadLine());

            SavingsAccount account = new SavingsAccount(startingBalance, annualInterestRate);

            decimal totalDeposits = 0;
            decimal totalWithdraws = 0;
            decimal totalInterestEarned = 0;

            for (int month = 1; month <= months; month++)
            {
                Console.WriteLine($"Enter amount deposited for month {month}: ");
                decimal depositAmount = decimal.Parse(Console.ReadLine());
                account.DepositMoney(depositAmount);
                totalDeposits += depositAmount;

                Console.WriteLine($"Enter amount withdrawn for month {month}: ");
                decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                account.WithDrawMoney(withdrawAmount);
                totalWithdraws += withdrawAmount;

                decimal balanceBeforeInterest = account.GetBalance();
                account.AddMonthlyInterest();
                decimal interestEarnedThatMonth = account.GetBalance() - balanceBeforeInterest;
                totalInterestEarned += interestEarnedThatMonth;

                Console.WriteLine();
            }

            Console.WriteLine($"Total deposited: {totalDeposits:C}");
            Console.WriteLine($"Total withdrawn: {totalWithdraws:C}");
            Console.WriteLine($"Interest earned: {totalInterestEarned:C}");
            Console.WriteLine($"Ending balance: {account.GetBalance():C}");
        }
    }
}
