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
                    int negativeNumberToPositive = guessNumber - randomNumber;
                    int negativeNumberToPositiveConversion = Math.Abs(negativeNumberToPositive);
                    int guessMinusRandom = guessNumber - randomNumber;

                    if (guessNumber != randomNumber && guesses >= 5)
                    {
                        Console.WriteLine("You have guessed too often! You failed");
                        gameRunning = false;
                        break;
                    }

                    if (guessNumber != randomNumber)
                    {
                        if (Enumerable.Range(1,5).Contains(guessMinusRandom) || negativeNumberToPositiveConversion <= 5)
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
            }
        }
    }
}