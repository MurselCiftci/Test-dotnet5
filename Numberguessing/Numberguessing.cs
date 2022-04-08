using System;
using System.Linq;

namespace Numberguessing
{
    internal class Numberguessing
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 20);
            int guesses = 0;
            bool gameRunning = true;

            Console.WriteLine("Hello, this is a GIT test");
            while (gameRunning == true)
            {
                while (true)
                {
                    Console.WriteLine("Guess the right number: ");

                    int guessNumber = Convert.ToInt32(Console.ReadLine());
                    int diff = guessNumber - randomNumber;
                    int absDiff = Math.Abs(diff);


                    if (guessNumber != randomNumber && guesses >= 5)
                    {
                        Console.WriteLine("You have guessed too often! You failed");
                        gameRunning = false;
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
                        gameRunning = false;
                        break;
                    }
                }
                Console.WriteLine("Do you want to play again? Enter Y if yes, enter N if no");
                string decisionRematch = Console.ReadLine();
                if (decisionRematch == "Y")
                {
                    guesses = 0;
                    randomNumber = rnd.Next(1, 20);
                    gameRunning = true;
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }

        }
    }
}



