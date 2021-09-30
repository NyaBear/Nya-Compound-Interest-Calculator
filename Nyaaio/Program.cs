using System;

namespace Nyaaio
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Nya Compound Interest Calculator";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("  _   _\n | \\ | |_   _  __ _\n |  \\| | | | |/ _` |\n | |\\  | |_| | (_| |\n |_| \\_|\\__, |\\__,_|\n        |___/\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" Compound Interest Rate Calculator!\n\n Enter your inital investement: \n\n [ > ] ");
            var initial = Console.ReadLine();
            Console.Write("\n Enter the rate ( % ) of your interest: \n\n [ > ] ");
            var rate = Console.ReadLine();
            Console.Write("\n Enter the length in ( years ) of your interest: \n\n [ > ] ");
            var years = Console.ReadLine();
            var total = Convert.ToInt32(initial) * Math.Pow(1 + Convert.ToInt32(rate), Convert.ToInt32(years));
            Console.WriteLine("\n The total value of your $" + initial + " investement after " + years + " years @ " + rate + "% is $" + total + ".\n\n The program automatically end in 10 seconds.");
            System.Threading.Thread.Sleep(10000);
            Console.ResetColor();
        }
    }
}