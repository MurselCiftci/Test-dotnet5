using System;

namespace Dotnet5
{
    internal class Reversestring
    {
        static void Main(string[] args)
        {
            static string ReverseString(string s) // MC here you create a method "Reversestring" where you need to pass in a string which will reverse it
            {
                char[] array = s.ToCharArray(); // Convert to char array
                Array.Reverse(array); // Then call Array.Reverse.
                return new string(array); // ... Finally use string constructor on array.
            }

            // edited code, what is below here I wrote myself

            Console.WriteLine("Enter a string: ");
            string reverseIt = Console.ReadLine();

            Console.WriteLine(ReverseString(reverseIt)); // Here you apply the method to reverse a string to the string variable reverseIT
        }
    }
}