using System;
using System.Linq;

namespace Numberguessing
{
    internal class Numberguessing
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool gameRunning = true;
            int MAX_GUESES = 5;

            Console.WriteLine("Hello, this is a GIT test");
            while (gameRunning == true)
            {
                int randomNumber = rnd.Next(1, 20);
                int guesses = 0;

                while (true)
                {
                    Console.WriteLine("Guess the right number: ");

                    int guessNumber = Convert.ToInt32(Console.ReadLine());
                    int diff = guessNumber - randomNumber;
                    int absDiff = Math.Abs(diff);


                    if (guessNumber != randomNumber && guesses >= MAX_GUESES)
                    {
                        Console.WriteLine("You have guessed too often! You failed");
                        break;
                    }

                    if (guessNumber != randomNumber)
                    {
                        if (absDiff <= 5)
                        {
                            Console.WriteLine("youre close!");
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
                    }
                    else
                    {
                        Console.WriteLine("You have won!");
                        break;
                    }
                }
                Console.WriteLine("Do you want to play again? Enter Y if yes, enter N if no");
                string decisionRematch = Console.ReadLine();
                if (decisionRematch.ToUpper() == "Y")
                {
                    Console.WriteLine("That's the spirit!");
                }
                else
                {
                    gameRunning = false;
                    Console.WriteLine("Goodbye!");
                }
            }
        }
    }
}



