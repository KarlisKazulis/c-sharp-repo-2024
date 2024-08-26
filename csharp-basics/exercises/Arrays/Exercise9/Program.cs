using System.Reflection.Metadata;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many words will you enter?");
            int numberOfWords = int.Parse(Console.ReadLine());

            string[] words = new string[numberOfWords];

            for (int i = 0; i < numberOfWords; i++)
            {
                Console.Write($"Please enter name {i + 1}: ");
                words[i] = Console.ReadLine();
            }
            string[] capitalizedArray = CapMe(words);

            Console.WriteLine(string.Join(", ", words));
            Console.WriteLine(string.Join(", ", capitalizedArray));
        }

        static string[] CapMe(string[] words)
        {
            string[] capitalizedWords = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    capitalizedWords[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }
            return capitalizedWords;
        }
    }
}
