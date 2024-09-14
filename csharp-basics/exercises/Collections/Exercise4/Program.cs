namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var namesHash = new HashSet<string>();
            Console.WriteLine("You can enter as many names as you you'd like. Enter a blank like to end the program.");

            while (true)
            {
                Console.WriteLine("Please enter names:");
                var userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    break;
                }

                namesHash.Add(userInput);
            }

            Console.WriteLine("Unique names you have entered: " + string.Join(' ', namesHash));
        }
    }
}
