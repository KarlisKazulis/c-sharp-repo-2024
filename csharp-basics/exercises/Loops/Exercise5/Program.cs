namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first word:");
            var firstWord = (Console.ReadLine());

            Console.WriteLine("Enter the second word:");
            var secondWord = (Console.ReadLine());

            int totalTextLength = 30;
            int dotsNeeded = 30 - firstWord.Length - secondWord.Length;

            Console.Write(firstWord);
            for (int i = 0; i < dotsNeeded; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine(secondWord);
        }
    }
}
