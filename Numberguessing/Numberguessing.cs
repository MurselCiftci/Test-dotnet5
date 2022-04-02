using System;

namespace Numberguessing
{
    internal class Numberguessing
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 20);
            int guesses = 0;

            while (true)
            {
                Console.WriteLine("Guess the right number: ");
                int guessNumber = Convert.ToInt32(Console.ReadLine());

                if (guessNumber - randomNumber < 5)
                {
                    Console.WriteLine("youre close");
                }

                if (guessNumber > randomNumber)
                {
                    Console.WriteLine("Your estimate is too high");
                    guesses++;
                }
                if (guessNumber < randomNumber)
                {
                    Console.WriteLine("Your estimate is too low");
                    guesses++;
                }
                if (guesses == 5)
                {
                    Console.WriteLine("You have guessed too often! Try again!");
                    Main(args);
                }
                if (guessNumber == randomNumber)
                {
                    Console.WriteLine("You have won!");
                    Main(args);
                }
            }
        }
    }
}