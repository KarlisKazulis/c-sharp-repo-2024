namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = new int[10];
            int[] copyArray = new int[10];


            var random = new Random();
            for (int i = 0; i < originalArray.Length; i++)
            {
                originalArray[i] = random.Next(1, 100);
            }
            
            Array.Copy(originalArray, copyArray, originalArray.Length); //using Copy method to copy all elements from one array to the other

            originalArray[originalArray.Length - 1] = -7;

            Console.Write("Array 1: ");
            foreach (int numbers in originalArray)
            {
                Console.Write(numbers + " ");
            }
            Console.WriteLine();

            Console.Write("Array 2: ");
            foreach (int numbers in copyArray)
            {
                Console.Write(numbers + " ");
            }
        }
    }
}
