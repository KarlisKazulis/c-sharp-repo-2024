using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int userChoice = GetMenu();

                if (userChoice == 1)
                {
                    CalculateCircleArea();
                }
                else if (userChoice == 2)
                {
                    CalculateRectangleArea();
                }
                else if (userChoice == 3)
                {
                    CalculateTriangleArea();
                }
                else if (userChoice == 4)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Enter a number between 1 and 4.");
                }
                Console.WriteLine();
            }
        }



        public static int GetMenu()
        {
            int userChoice;

            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4): ");
            var keyboard = Console.ReadKey();
            userChoice = int.Parse(keyboard.KeyChar.ToString());
            Console.WriteLine();
            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            Console.WriteLine("What is the circle's radius? ");
            var radius = double.Parse(Console.ReadLine());
            if (radius <= 0)
            {
                Console.WriteLine("Radius cannot be negative");
                return;
            }
            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
        }

        public static void CalculateRectangleArea()
        {
            Console.WriteLine("Enter rectangle length:");
            var length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter rectangle width:");
            var width = double.Parse(Console.ReadLine());

            if (length <= 0 || width <= 0)
            {
                Console.WriteLine("Rectangle length and/or width cannot be 0 or less");
                return;
            }
            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfTriangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
            Console.WriteLine("Enter length of the triangle's base?");
            var ground = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter triangle's height?");
            var height = double.Parse(Console.ReadLine());

            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfRectangle(ground, height));
        }
    }
}
