using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string Name = "Zed A. Shaw";
            int Age = 35;
            int Height = 74;  // inches
            int  Weight = 180; // lbs 
            string Eyes = "Blue";
            string Teeth = "White";
            string Hair = "Brown";

            Console.WriteLine("Let's talk about " + Name + ".");
            Console.WriteLine("He's " + (Height * 2.54).ToString("0.00") + " cm tall.");
            Console.WriteLine("He's " + (Weight * 0.45359237).ToString("0.00") + " kg heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + Eyes + " eyes and " + Hair + " hair.");
            Console.WriteLine("His teeth are usually " + Teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + Age + ", " + (Height * 2.54).ToString("0.00") + ", and "
                              + (Weight * 0.45359237).ToString("0.00")
                              + " I get " + (Age + (Height * 2.54) + (Weight * 0.45359237)).ToString("0.00") + ".");

            Console.ReadKey();
        }
    }
}