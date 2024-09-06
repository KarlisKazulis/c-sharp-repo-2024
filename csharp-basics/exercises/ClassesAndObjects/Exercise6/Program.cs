namespace Exercise6
{
    internal class DogTest
    {
        static void Main(string[] args)
        {
            Dog max = new Dog("Max", "male");
            Dog rocky = new Dog("Rocky", "male");
            Dog sparky = new Dog("Sparky", "male");
            Dog buster = new Dog("Buster", "male");
            Dog sam = new Dog("Sam", "male");
            Dog lady = new Dog("Lady", "female");
            Dog molly = new Dog("Molly", "female");
            Dog coco = new Dog("Coco", "female");

            max.SetParents(lady, rocky);
            coco.SetParents(molly, buster);
            rocky.SetParents(molly, sam);
            buster.SetParents(lady, sparky);

            Console.WriteLine($"{coco.GetFatherName()}");
            Console.WriteLine($"{sparky.GetFatherName()}");

            Console.WriteLine($"{coco.HasSameMotherAs(rocky)}");
        }
    }
}
