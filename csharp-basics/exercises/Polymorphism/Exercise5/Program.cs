namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hoarding1 = new Hoarding(150, 5, 15, true);
            var hoarding2 = new Hoarding(150, 7, 15, false);
            var newspaper = new Newspaper(170, 100, 5);
            var tvcommercial1 = new TVCommercial(500, 30, 10, true);
            var tvCommercial2 = new TVCommercial(500, 30, 10, false);
            var poster = new Poster(140, 1000, 4);

            Console.WriteLine(hoarding1);
            Console.WriteLine(hoarding2);
            Console.WriteLine(newspaper);
            Console.WriteLine(tvcommercial1);
            Console.WriteLine(tvCommercial2);
            Console.WriteLine(poster);
        }
    }
}
