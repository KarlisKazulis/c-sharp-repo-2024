using System.Runtime.CompilerServices;

namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock, paper, scissors. Enter your move:");
            string myMove = Console.ReadLine().ToLower();

            string[] moves = { "rock", "paper", "scissors" };

            string computerMove = RandomMove(moves);

            Console.WriteLine($"Your move was:  {myMove}");
            Console.WriteLine($"Computer's move was:  {computerMove}");


            if (myMove == "rock" && computerMove == "scissors" ||
                myMove == "paper" && computerMove == "rock" ||
                myMove == "scissors" && computerMove == "paper")
            {
                Console.WriteLine("User wins!");
            }
            else if (myMove == "rock" && computerMove == "paper" ||
                     myMove == "paper" && computerMove == "scissors" ||
                     myMove == "scissors" && computerMove == "rock")
            {
                Console.WriteLine("Computer wins!");
            }
            else if (myMove == computerMove)
            {
                Console.WriteLine("Tie!");
            }
            else
            {
                Console.WriteLine("Please enter either rock, paper, or scissors. ");
            }
        }

        private static string RandomMove(string[] moves)
        {
            Random random = new Random();
            int index = random.Next(moves.Length);
            return moves[index];
        }
    }
}
