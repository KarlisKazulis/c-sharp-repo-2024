namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            var input1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            var input2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter one of the operators (+, -, *, /)");
            string operatorUsed = Console.ReadLine();

            double result = 0;

            if (operatorUsed == "+")
            {
                result = input1 + input2;
            }
            else if (operatorUsed == "-")
            {
                result = input1 - input2;
            }
            else if (operatorUsed == "*")
            {
                result = input1 * input2;
            }
            else if (operatorUsed == "/")
            {
                if (input2 == 0)
                {
                    Console.WriteLine("You cannot divide with a zero");
                    return;
                }
                else
                {
                    result = input1 / input2;
                }
            }
            else
            {
                Console.WriteLine("Pick an operator between +, -, *, /");
            }

            Console.WriteLine($"Your result: {input1} {operatorUsed} {input2} = {result}");

        }
    }
}
