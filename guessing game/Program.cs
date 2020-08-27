using System;
using System.IO;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rnumber = rnd.Next(1, 100);
            Console.WriteLine("GUESSING GAME");
            Console.WriteLine("I am thinking of a number between 0 and 100");
            Console.WriteLine("Try your luck and guess my number");
            int guess;
            int count = 0;

            do
            {
                Console.WriteLine();
                string input = Console.ReadLine();
                count++;
               
               
                
                int.TryParse(input, out guess);

                
                if (guess < rnumber)
                {
                    Console.WriteLine($"Your guess of {guess} too low, Try again");
                    Console.WriteLine();


                }
                else if (guess > rnumber)
                {
                    Console.WriteLine($"Your guess of {guess} too high, Try again");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"YOU WON THE NUMBER WAS {guess}");
                    Console.WriteLine($"It took you {count} tries to guess the correct number");
                }

            } while (guess != rnumber);
        }
    }
}
