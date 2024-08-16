namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number of minutes and I will convert them into years and days");
            string minutes = Console.ReadLine();

            int minutesInYear = 525600;
            int minutesInDay = 1440;

            int years = Int32.Parse(minutes) / minutesInYear;
            int remainingMinutes = Int32.Parse(minutes) % minutesInYear;
            int days = remainingMinutes / minutesInDay;

            Console.WriteLine(minutes + " minutes is " + years + " year(s) and " + days + " days."  );
        }
    }
}
