namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight in KG's: ");
            var weightInKilos = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height in meters: ");
            var heightInMeters = double.Parse(Console.ReadLine());

            double weightInPounds = weightInKilos * 2.20462;
            double heightInInches = heightInMeters * 39.3701;

            double bmi = (weightInPounds * 703) / Math.Pow(heightInInches, 2);

            if (bmi > 25)
            {
                Console.WriteLine($"You are overweight. BMI: {bmi}");
            }
            else if (bmi < 18.5)
            {
                Console.WriteLine($"You are underweight. BMI: {bmi}");
            }
            else
            {
                Console.WriteLine($"You have optimal weight. BMI: {bmi}");
            }
        }


    }
}
