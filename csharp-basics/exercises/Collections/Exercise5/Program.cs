namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and I will tell you whether its happy or not");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (IsHappyNumber(number))
                {
                    Console.WriteLine($"{number} is a happy number");
                }
                else
                {
                    Console.WriteLine($"{number} is not a happy number");
                }
            }
        }
        public static bool IsHappyNumber(int number)
        {
            HashSet<int> numbers = new HashSet<int>();

            while (number != 1 && !numbers.Contains(number))
            {
                numbers.Add(number);
                number = DigitSquareSum(number);
            }

            return number == 1;
        }

        public static int DigitSquareSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit * digit;
                number /= 10;
            }

            return sum;
        }
    }
}
