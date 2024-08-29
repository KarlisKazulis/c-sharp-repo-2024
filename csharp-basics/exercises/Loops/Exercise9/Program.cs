namespace Exercise9
{
    internal class RollTwoDice
    {
        static void Main(string[] args)
        {
            int desiredSum = inputAfterValidation();
            DiceRoll(desiredSum);
        }

        static int inputAfterValidation()
        {
            int desiredSum;
            while (true)
            {
                Console.WriteLine("Desired sum: ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out desiredSum) && desiredSum > 2 || desiredSum <= 12)
                {
                    return desiredSum;
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer between 2 and 12");
                }
            }
        }
        
        static void DiceRoll(int desiredSum)
        {
            Random random = new Random();
            int dice1, dice2;

            while (true)
            {
                dice1 = random.Next(1, 7);
                dice2 = random.Next(1, 7);
                int diceSum = dice1 + dice2;

                Console.WriteLine($"You have rolled {dice1} and {dice2}. Sum: {diceSum}");

            if (diceSum == desiredSum)
                {
                    break;
                }
            }
            Console.WriteLine("You have rolled your desired sum: " + desiredSum);
        }
    }
}
