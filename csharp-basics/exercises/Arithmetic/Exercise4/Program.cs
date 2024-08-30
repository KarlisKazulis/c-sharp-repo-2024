namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program computes the factorial of 10.");

            int product = 1;

            for (int i = 1; i <= 10; i++)
            {
                product = product * i;
            }

            Console.WriteLine(product);
        }
    }
}
