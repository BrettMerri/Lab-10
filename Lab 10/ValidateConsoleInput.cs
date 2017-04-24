using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class ValidateConsoleInput
    {
        #region Integer
        public static int GetValidInteger()
        {
            int Input;
            while (!int.TryParse(Console.ReadLine(), out Input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Invalid input. Try again: ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return Input;
        }

        public static int GetIntegerInRange(int Min, int Max)
        {
            int Input = GetValidInteger();
            while (Input < Min || Input > Max)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Input not between {Min} and {Max}. Try again: ");
                Console.ForegroundColor = ConsoleColor.White;
                Input = GetValidInteger();
            }
            return Input;
        }
        #endregion

        #region Double
        public static double GetValidDouble()
        {
            double Input;
            while (!double.TryParse(Console.ReadLine(), out Input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Invalid input. Try again: ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return Input;
        }

        public static double GetDoubleInRange(double Min, double Max)
        {
            double Input = GetValidDouble();
            while (Input < Min || Input > Max)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Input not between {Min} and {Max}. Try again: ");
                Console.ForegroundColor = ConsoleColor.White;
                Input = GetValidDouble();
            }
            return Input;
        }
        #endregion

        #region String
        public static string GetValidString(string[] Options)
        {
            string Input;
            while (true)
            {
                Input = Console.ReadLine().ToLower();
                foreach (string item in Options)
                {
                    if (Input == item)
                        return Input;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Invalid input. Try again: ");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        #endregion
    }
}
