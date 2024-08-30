namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number. I'll check whether it's odd or even");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }

            Console.WriteLine("Bye!");
        }
    }
}
