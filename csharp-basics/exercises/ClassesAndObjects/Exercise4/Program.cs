namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Casino Royale", "Eon Productions", "PG-13");
            Movie movie2 = new Movie("Glass", "Buena Vista International", "PG-13");
            Movie movie3 = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");

            Movie[] movies = { movie1, movie2, movie3 };

            Movie[] pgMovies = GetPG(movies);

            Console.WriteLine("PG movies are: ");
            foreach (Movie movie in pgMovies)
            {
                Console.WriteLine(movie.PrintMovie());
            }
        }

        public static Movie[] GetPG(Movie[] movies) {
            
            List<Movie> pgMovieList = new List<Movie>();

            foreach (Movie movie in movies)
            {
                if (movie.GetMovieRating() == "PG")
                {
                    pgMovieList.Add(movie);
                }
            }

            return pgMovieList.ToArray();
        }
    }
}
