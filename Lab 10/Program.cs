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

            Console.Write("What category are you interested in? (Animated, Drama, Horror, Scifi): ");
            ValidateConsoleInput.GetValidString(Options);


        }
    }
}
