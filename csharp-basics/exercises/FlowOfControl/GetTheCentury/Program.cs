using System;

namespace GetTheCentury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a year between 1000 and 2010 and I will tell you what century it is.");
            var input = int.Parse(Console.ReadLine());

            Century(input);

        }

        private static void Century(int year)
        {
            if (year < 1000 || year > 2010)
            {
                Console.WriteLine("Invalid year");
                
            }
            else if (year > 1000 && year <= 1100)
            {
                Console.WriteLine("11th century");
            }
            else if (year > 1100 && year <= 1200)
            {
                Console.WriteLine("12th century");
            }
            else if (year > 1200 && year <= 1300)
            {
                Console.WriteLine("13th century");
            }
            else if (year > 1300 && year <= 1400)
            {
                Console.WriteLine("14th century");
            }
            else if (year > 1400 && year <= 1500)
            {
                Console.WriteLine("15th century");
            }
            else if (year > 1500 && year <= 1600)
            {
                Console.WriteLine("16th century");
            }
            else if (year > 1600 && year <= 1700)
            {
                Console.WriteLine("17th century");
            }
            else if (year > 1700 && year <= 1800)
            {
                Console.WriteLine("18th century");
            }
            else if (year > 1800 && year <= 1900)
            {
                Console.WriteLine("19th century");
            }
            else if (year > 1900 && year <= 2000)
            {
                Console.WriteLine("20th century");
            }
            else if (year == 1000)
            {
                Console.WriteLine("10th century");
            }
            else 
            {
                Console.WriteLine("21th century");
            }


        }
    }
}
