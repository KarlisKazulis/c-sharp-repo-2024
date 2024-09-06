namespace Exercise12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITestpaper paper1 = new Testpaper("Maths", new string[] { "1A", "2C", "3D", "4A", "5A" }, "60%");
            ITestpaper paper2 = new Testpaper("Chemistry", new string[] { "1C", "2C", "3D", "4A" }, "75%");
            ITestpaper paper3 = new Testpaper("Computing", new string[] { "1D", "2C", "3C", "4B", "5D", "6C", "7A" }, "75%");

            IStudent student1 = new Student();
            IStudent student2 = new Student();

            student1.TakeTest(paper1, new string[] { "1A", "2D", "3D", "4A", "5A" });
            
            Console.WriteLine("Student 1 Tests Taken:");
            foreach (string result in student1.TestsTaken)
            {
                Console.WriteLine(result);
            }

            student2.TakeTest(paper2, new string[] { "1C", "2D", "3A", "4C" });
            student2.TakeTest(paper3, new string[] { "1A", "2C", "3A", "4C", "5D", "6C", "7B" });

            Console.WriteLine("Student 2 Tests Taken: ");
            foreach (string result in student2.TestsTaken)
            {
                Console.WriteLine(result);  
            }
        }
    }
}
