using System;

namespace Dotnet5
{
    internal class NumberGuessing
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 100);
            int guessesAmount = 0;

            while (true)
            {
                Console.WriteLine("Welcome. Guess the right number: ");
                int guessNumber = Convert.ToInt32(Console.ReadLine());

                if (guessNumber != randomNumber && guessesAmount < 9)
                {
                    if (guessNumber > randomNumber)
                    {
                        Console.WriteLine("Your estimate is too high");
                        guessesAmount++;
                    }
                    else 
                    {
                        Console.WriteLine("Your estimate is too low");
                        guessesAmount++;
                    }
                }
                if (guessNumber == randomNumber)
                {
                    Console.WriteLine("You won");
                    break;
                }
                else
                {
                    Console.WriteLine("You;ve tried too many times");
                    break;
                }
            }
        }
    }
}