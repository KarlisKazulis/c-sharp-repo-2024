namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> randomHashSet = new HashSet<string>();

            randomHashSet.Add("item1");
            randomHashSet.Add("item2");
            randomHashSet.Add("item3");
            randomHashSet.Add("item4");
            randomHashSet.Add("item5");

            foreach (var value in randomHashSet)
            {
                Console.WriteLine(value);
            }

            randomHashSet.Clear();
            Console.WriteLine();
            
            randomHashSet.Add("dup");
            randomHashSet.Add("dup");

            foreach (var value in randomHashSet)
            {
                Console.WriteLine(value);
            }
        }
    }
}
