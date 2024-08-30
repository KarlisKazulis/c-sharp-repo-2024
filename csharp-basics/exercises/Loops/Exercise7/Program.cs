namespace Exercise7
{
    internal class Piglet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");
            PlayPigletGame();
        }

        static void PlayPigletGame()
        {
            Random random = new Random();
            int totalPoints = 0;
            bool keepPlaying = true;

            while (keepPlaying)
            {
                int diceRoll = random.Next(1, 7);
                Console.WriteLine($"You have rolled a {diceRoll}!");

                if (diceRoll == 1)
                {
                    totalPoints = 0;
                    Console.WriteLine("You got 0 points. You're out!");
                    keepPlaying = false;
                }
                else
                {
                    totalPoints += diceRoll;
                    Console.WriteLine("Do you want to roll again? (y/n)");
                    string userInput = Console.ReadLine().Trim().ToLower();

                    while (userInput != "y" && userInput != "n")
                    {
                        Console.WriteLine("Error! Invalid input. Please enter either 'y' or 'n'.");
                        userInput = Console.ReadLine().Trim().ToLower();
                    }

                    if (userInput == "n")
                    {
                        keepPlaying = false;
                    }
                }
            }
            Console.WriteLine($"In total you've got {totalPoints} points");
        }
    }
}
