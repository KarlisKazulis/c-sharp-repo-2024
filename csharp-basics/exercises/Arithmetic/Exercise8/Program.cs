namespace Exercise8
{
    internal class Program
    {
        static bool IsValidInput(double basePay, int hoursWorked)
        {
            if (basePay < 8.00)
            {
                Console.WriteLine("Error! Base pay minimum of $8.00 is not met.");
                return false;
            }

            if (hoursWorked > 60)
            {
                Console.WriteLine("Error! Workers cannot work more than 60 hours per week.");
                return false;
            }
            return true;
        }
        static void CalculatePay(double basePay, int hoursWorked)
        {
            double regularPay;
            double overtimePay = 0;

            if (!IsValidInput(basePay, hoursWorked))
            {
                return;
            }

            if (hoursWorked > 40)
            {
                int overtimeHours = hoursWorked - 40;
                regularPay = 40 * basePay;
                overtimePay = overtimeHours * basePay * 1.5;
            }
            else
            {
                regularPay = hoursWorked * basePay;
            }

            double totalPay = regularPay + overtimePay;

            Console.WriteLine($"Total pay: ${totalPay}");
        }
        static void Main(string[] args)
        {
            CalculatePay(7.50, 35);
            CalculatePay(8.20, 47);
            CalculatePay(10.00, 73);
        }
    }
}
