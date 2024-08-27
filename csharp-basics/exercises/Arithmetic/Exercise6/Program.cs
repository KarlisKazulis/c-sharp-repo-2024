namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int numbersPerLine = 11;

            for (int i = 1; i <= 110; i++)
            {
                string programOutput = "";

                if (i % 3 == 0) programOutput += "Coza";
                if (i % 5 == 0) programOutput += "Loza";
                if (i % 7 == 0) programOutput += "Woza";

                if (programOutput == "")
                {
                    programOutput = i.ToString(); //numbers that are not multiples of 3, 5 or 7 just get printed
                }

                Console.Write($"{programOutput, -8}");

                if (i % numbersPerLine == 0) //if numbers per line reach 11, move to next line
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
