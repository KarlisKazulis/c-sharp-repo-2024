namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text and I'll check if Nemo is mentioned");
            string userInput = Console.ReadLine();

            Console.WriteLine(FindNemo(userInput));
        }

        public static string FindNemo(string input)
        {
            string[] text = input.Split(' ');

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == "Nemo")
                {
                    return $"I found Nemo at {i + 1}!";
                }
            }

            return "I can't find Nemo :(";
        }
    }
}
