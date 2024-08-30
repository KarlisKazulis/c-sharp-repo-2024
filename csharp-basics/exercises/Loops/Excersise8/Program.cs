namespace Exercise8
{
    internal class AsciiFigure
    {
        static void Main(string[] args)
        {
            const int size = 7;

            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < 2 * (size - i); j++) //every iteration number of / reduces 
                {
                    Console.Write("/");
                }
                for (int j = 0; j < 4 * (i - 1); j++)  //every iteration number of * increases
                {
                    Console.Write("*");
                }
                for (int j = 0; j < 2 * (size - i); j++) //every iteration number of \\ decreases 
                {
                    Console.Write("\\");
                }
                Console.WriteLine();
            }
        }
    }
}