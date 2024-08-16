namespace Exercise_6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter random numbers and press enter!");
        string numbers = Console.ReadLine();

        var sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {

            sum += int.Parse(numbers[i].ToString());


        }

        Console.WriteLine("sum of all numbers");
        Console.WriteLine(sum);

    }
}