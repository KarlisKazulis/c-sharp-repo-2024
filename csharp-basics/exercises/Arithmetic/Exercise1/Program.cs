namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'll accept two integers and return true if either one is 15 or their sum" +
                              " or difference is 15.");
            Console.WriteLine("Enter the first number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int number2 = int.Parse(Console.ReadLine());

            bool result = (number1 == 15) || (number2 == 15) ||
                          (number1 + number2) == 15 || (Math.Abs(number1 - number2) == 15);

            Console.WriteLine("Result is: " + result);
        }
    }
}
