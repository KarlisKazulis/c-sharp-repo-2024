namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I will convert uppercase characters to lower and vice-versa");
            Console.WriteLine("Enter a string:");
            string userInput = Console.ReadLine();
            string convertedString = ReverseTheCase(userInput);
            Console.WriteLine(convertedString);
        }
        static string ReverseTheCase(string input)
        {
            char[] stringCharacters = input.ToCharArray();

            for (int i = 0; i < stringCharacters.Length; i++)
            {
                if (char.IsLower(stringCharacters[i]))
                {
                    stringCharacters[i] = char.ToUpper(stringCharacters[i]);
                }
                else
                {
                    stringCharacters[i] = char.ToLower(stringCharacters[i]);
                }
            }

            string reversedString = string.Join("", stringCharacters);
            return reversedString;
        }
    }
}
