namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter distance in meters!");
            double meters = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter hours");
            double hours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter minutes");
            double minutes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter seconds");
            double seconds = Convert.ToDouble(Console.ReadLine());

            double timeInSeconds = (hours * 3600) + (minutes * 60) + seconds; //katra stunda ir 3600 sekundes un minute - 60
            double metersPersecond = meters / timeInSeconds;

            double kilometersPerHour = (meters / 1000) / (timeInSeconds / 3600);

            double milesPerHour = kilometersPerHour * 0.621371; //1 km  = 0.621371 miles

            Console.WriteLine($"Your speed in meters/second is {Math.Round(metersPersecond, 8)}");
            Console.WriteLine($"Your speed in km/h is {Math.Round(kilometersPerHour, 8)}");
            Console.WriteLine($"Your speed in miles/h is {Math.Round(milesPerHour, 8)}");

        }
    }
}
