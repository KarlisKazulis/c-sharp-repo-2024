using System.Security.Cryptography.X509Certificates;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number that represents a day");
            var day = int.Parse(Console.ReadLine());

            
            
            switch (day)
            {
                case 0:
                    Console.Write("Sunday");
                    break;
                case 1:
                    Console.Write("Monday");
                    break;
                case 2:
                    Console.Write("Tuesday");
                    break;
                case 3:
                    Console.Write("Wednesday");
                    break;
                case 4:
                    Console.Write("Thursday");
                    break;
                case 5:
                    Console.Write("Friday");
                    break;
                case 6:
                    Console.Write("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }   

            //OR
            /*
            if (day >= 0 && day <= 6)
            {
                if (day == 0)
                {
                    Console.WriteLine("Sunday");
                }
                else if (day == 1)
                {
                    Console.Write("Monday");
                }
                else if (day == 2)
                {
                    Console.Write("Tuesday");
                }
                else if (day == 3)
                {
                    Console.Write("Wednesday");
                }
                else if (day == 4)
                {
                    Console.Write("Thursday");
                }
                else if (day == 5)
                {
                    Console.Write("Friday");
                }
                else if (day == 6)
                {
                    Console.Write("Saturday");
                }

            }
            else
            {
                Console.WriteLine("Invalid input. No such day exists.");
            }
            */
            
        }
    }
}
