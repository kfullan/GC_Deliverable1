using System;

namespace deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool retry = true;

            while (retry)
            {
                Console.WriteLine("Select a number:");
                Console.WriteLine("1. Inches to Fidget Spinners.");
                Console.WriteLine("2. Fidget Spinners to Inches.");
                Console.WriteLine("3. Feet to Memes.");
                Console.WriteLine("4. Memes to Feet.");
                string input = Console.ReadLine();


                if (input == "1")
                {
                    Console.WriteLine("How many inches would you like to convert into fidget spinners?");
                    double inch = double.Parse(Console.ReadLine());
                    double fidgetSpinners = 3.5 * inch;
                    Console.WriteLine($"The conversion for {inch} inches is {fidgetSpinners} fidget spinners.");
                }
                else if (input == "2")
                {
                    Console.WriteLine("How many fidget spinners would you like to convert into inches");
                    double fidgetSpinners = double.Parse(Console.ReadLine());
                    double inch = fidgetSpinners / 3.5;
                    Console.WriteLine($"The conversion for {fidgetSpinners} fidget spinners is {inch} inch(es).");

                }
                else if (input == "3")
                {
                    Console.WriteLine("How many feet would you like to convert into memes?");
                    double feet = double.Parse(Console.ReadLine());
                    double meme = 5 * feet;
                    Console.WriteLine($"The conversion for {feet} feet is {meme} memes.");

                }
                else if (input == "4")
                {
                    Console.WriteLine("How many memes would you like to convert into feet?");
                    double meme = double.Parse(Console.ReadLine());
                    double feet = meme / 5;
                    Console.WriteLine($"The conversion for {meme} meme(s) is {feet} feet.");
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
                Console.WriteLine("Would you like to calculate another conversion? (Yes/No)");
                string userInput = Console.ReadLine().ToLower();
                Console.Clear();
                if (userInput == "yes")
                {
                    retry = true;
                }
                else
                {
                    Console.WriteLine("End.");
                    retry = false;
                }
            }
        }
    }
}
