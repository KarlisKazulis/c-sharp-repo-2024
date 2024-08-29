namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxValue;

            while (true)
            {
                Console.Write("Max value? ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out maxValue))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer");
                }
            }

            int numbersPerline = 0;

            for (int i = 1; i <= maxValue; i++)
            {
                string output = "";

                if (i % 3 == 0 && i % 5 == 0)
                {
                    output = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    output = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    output = "Buzz";
                }
                else
                {
                    output = i.ToString();
                }

                Console.Write(output + " ");
                numbersPerline++;

                if (numbersPerline % 20 == 0)
                {
                    Console.WriteLine();
                }
            }

        }

    }
}

