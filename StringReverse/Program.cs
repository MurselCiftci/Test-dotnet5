using System;

namespace StringReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fill in the string you want to reverse here: ");
            string s = Console.ReadLine(); 
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine(chars);
        }
    }
}
