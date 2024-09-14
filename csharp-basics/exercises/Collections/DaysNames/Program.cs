using System;

class Program
{
    public static void Main()
    { 
        Enum.GetNames(typeof(DayOfWeek)).ToList().ForEach(Console.WriteLine);
    }
}