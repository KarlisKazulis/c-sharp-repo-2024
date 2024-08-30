namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            GetRandomNumberPosition();
        }
        static void GetRandomNumberPosition()
        {
            Random random = new Random();
            int[] randomNumbers = new int[20];

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(1, 101);
            }

            int position;
            while (true)
            {
                Console.WriteLine("What number position would you like to know? (1-20) ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out position) && position >= 1 && position <= 20)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error! Please enter a number between 1 and 20!");
                }
            }
            Console.WriteLine($"Out of 20, number at position {position} is: {randomNumbers[position - 1]} ");
            Console.WriteLine("Here is the full array!");
            Console.WriteLine(string.Join(", ", randomNumbers));
        }
    }
}
