namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randNumber = rand.Next(1, 101);

            Console.WriteLine("Try to guess a number between 1-100.");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < 1 || userGuess > 100)
            {
                Console.WriteLine("Invalid input, enter a number between 1 and 100");
                return;
            }
            if (userGuess > randNumber)
            {
                Console.WriteLine("Sorry, you are too high. I was thinking of " + randNumber);
            }
            else if (userGuess < randNumber)
            {
                Console.WriteLine("Sorry, you are too low. I was thinking of " + randNumber);
            }
            else if (userGuess == randNumber)
            {
                Console.WriteLine("You guessed it! What are the odds??");
            }
        }

    }
}
