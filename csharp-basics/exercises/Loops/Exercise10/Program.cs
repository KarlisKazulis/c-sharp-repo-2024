
namespace Exercise10
{
    internal class NumberSquare
    {
        static void Main(string[] args)
        {
            int min = InputAfterValidation("Min? ");
            int max = InputAfterValidation("Max? ");
            PrintNumberSquare(min, max);

        }

        static int InputAfterValidation(string input)
        {
            int number;
            while (true)
            {
                Console.Write(input);
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer");
                }

            }
        } 
        
        static void PrintNumberSquare(int min, int max)
        {
            int range = max - min + 1;

            for (int i = 0; i < range; i++)  //looping through each row of the matrix
            {
                for (int j = 0; j < range; j++) //looping through each column of the matrix
                {
                    int currentNumber = min + (i + j) % range;
                    Console.Write(currentNumber);
                }
                Console.WriteLine();
            }
        }
    }
}
