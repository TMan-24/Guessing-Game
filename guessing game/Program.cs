using System;
using System.IO;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guessing Game
            Console.WriteLine("GUESSING GAME");
            Console.WriteLine("Between what two numbers would you like to pick from?");
            
            Console.Write("First number (lowest number): ");
            string string1 = Console.ReadLine();

            Console.Write("Second number (Highest number): ");
            string string2 = Console.ReadLine();

            int num1, num2;

            int.TryParse(string1, out num1);
            int.TryParse(string2, out num2);

            Random rnd = new Random();
            int rnumber = rnd.Next(num1, num2);
            Console.WriteLine($"I am thinking of a number between {num1} and {num2}");
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
                  
                }
                else if (guess > rnumber)
                {
                    Console.WriteLine($"Your guess of {guess} too high, Try again");                   
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
