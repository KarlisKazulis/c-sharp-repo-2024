namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                string result = CheckNumber(number);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Please enter a valid integer");
            }
        }
        static string CheckNumber(int number)
        {
            int sumOfDigits = CalculateSumOfDigits(number);

            if (number % sumOfDigits != 0)
            {
                return "Neither";
            }

            int resultOfDivision = number / sumOfDigits;

            if (IsPrime(resultOfDivision))
            {
                return "M";
            }
            else
            {
                return "H";
            }
        }
        static int CalculateSumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number = number / 10;
            }
            return sum;
        }
        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;
            for (int i = 5; i * i <= number; i = i + 6)
            {
                if (number % i == 0 || number % (i + 2) == 0) return false;
            }
            return true;
        }
    }

}
