/* Default File's content
using System;

namespace Nyaaio
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 38498.3222;

            string dinosaur = "Barney";

            double a = 293.000;

            bool yes = true;

            string band = "The Low Anthem";
        }
    }
}*/

/*Here's what you learned:

DATA TYPES: int, double, char, string, bool
VARIABLES: datatype variableName = value;
COMMON ERRORS: wrong type, wrong value, no semicolon
DATA TYPE CONVERSION: implicit, explicit, methods

Good luck! */

/*
using System;

namespace Nyaaio
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Nya Aio | v0.1 | Alpha Phase";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("  _   _                  _    _       \n | \\ | |_   _  __ _     / \\  (_) ___  \n |  \\| | | | |/ _` |   / _ \\ | |/ _ \\ \n | |\\  | |_| | (_| |  / ___ \\| | (_) |\n |_| \\_|\\__, |\\__,_| /_/   \\_\\_|\\___/ \n        |___/                         \n");
            Console.ResetColor();
            Console.Write(" Welcome to my 1st C# program, This program outputs a statement about you :D\n\n Please enter your name below: \n\n [ > ] ");
            string name = Console.ReadLine();
            Console.Write("\n Please enter your favourite number below: \n\n [ > ] ");
            string favnum = Console.ReadLine();
            Console.Write("\n Name: " + name + "\n\n Favourite Number: " + favnum + "\n");
        }
    }
}
*/

using System;

namespace PlanetCalculations
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int userAge = 15;
            double jupiterYears = 11.86;
            double journeyToJupiter = 6.142466;
            double newEarthAge = userAge + journeyToJupiter;
            double newJupiterAge = newEarthAge / jupiterYears;
            Console.WriteLine("Earth Age: " + newEarthAge);
            Console.WriteLine("Jupter Age: " + newJupiterAge);
        }
    }
}