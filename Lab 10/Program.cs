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
            Console.Title = "Lab 10 - Movie List Application"; //Set console title

            //Set default console colors
            Console.ForegroundColor = ConsoleColor.White; 
            Console.BackgroundColor = ConsoleColor.Black;

            List<Movie> MovieList = new List<Movie>(); //Creates a list of Movie objects named MovieList.

            //Adds 12 movies to the MovieList each with a title and category
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

            string[] Options = { "animated", "drama", "horror", "scifi" }; //Declare movie categories in an Options array
            bool loop = true; //Set loop to true

            Console.WriteLine("Welcome to the Movie List Application!\n");
            Console.WriteLine("There are 100 moview in this list.");

            while (loop) //Loop application while loop is true
            {
                Console.Write("What category are you interested in? (Animated, Drama, Horror, or Scifi): "); //Prompts user to enter a category
                string CategoryInput = ValidateConsoleInput.GetValidString(Options); //Gets input from user and validates that the input is one of the categories in the options array

                foreach (Movie item in MovieList) //For each movie in the movie list
                {
                    if (item.MovieCategory == CategoryInput) //If the movie category equals the category input
                    {
                        Console.WriteLine(item.MovieTitle); //Write the movie title
                    }
                }
                if (!ContinueApp()) //Prompts user if he wants to continue. Set loop to false if use does not want to continue.
                    loop = false;
            }
        }
        public static bool ContinueApp()
        {
            while (true) //Loop ContinueApp in case of an error
            {
                Console.Write("Do you want to continue? (y/n): "); //Prompts user if he wants to continue
                string input = Console.ReadLine().ToLower(); //set lowercase input to string input
                if (input == "y") //If input = y return true
                {
                    Console.WriteLine();
                    return true;
                }
                else if (input == "n") //If input = n return false
                    return false;
                else //If input is not y or n, return an error and ask for y or n again
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Input not y or n.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

    }
}
