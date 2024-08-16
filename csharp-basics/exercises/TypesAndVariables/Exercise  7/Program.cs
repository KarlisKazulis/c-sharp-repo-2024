namespace Exercise__7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string!");
            string word = Console.ReadLine();

            var counter = 0;
            for (int i = 0; i < word.Length; i++)
            {

                

                if (char.IsUpper(word[i]))
                {
                    counter++;
                }

            }

            Console.WriteLine("String " + word + " contains " + counter + " uppercase letters.");
            Console.ReadKey();


        }
    }
}