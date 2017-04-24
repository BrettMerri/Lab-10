using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lab 10 - Movie List Application";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            string[] Options = { "animated", "drama", "horror", "scifi" };

            Console.WriteLine("Welcome to the Movie List Application!\n");
            Console.WriteLine("There are 100 moview in this list.");

            Console.Write("What category are you interested in? (Animated, Drama, Horror, or Scifi): ");
            string Category = ValidateConsoleInput.GetValidString(Options);

            List<Movie> MovieList = new List<Movie>();

            MovieList.Add(new Movie("The Matrix", "scifi"));
            MovieList.Add(new Movie("Intersteller", "scifi"));
            MovieList.Add(new Movie("Star Wars", "scifi"));
            MovieList.Add(new Movie("Toy Story", "animated"));
            MovieList.Add(new Movie("Finding Nemo", "animated"));
            MovieList.Add(new Movie("The Lion King", "animated"));
            MovieList.Add(new Movie("Titanic", "drama"));
            MovieList.Add(new Movie("The Godfather", "drama"));
            MovieList.Add(new Movie("Fight Club:", "drama"));
            MovieList.Add(new Movie("The Shining", "horror"));
            MovieList.Add(new Movie("The Exorcist", "horror"));
            MovieList.Add(new Movie("The Conjuring", "horror"));

            foreach (Movie item in MovieList)
            {
                if (item.MovieCategory == Category)
                {
                    Console.WriteLine(item.MovieTitle);
                }
            }
        }
    }
}
