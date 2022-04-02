using System;

namespace Dotnet5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double laborCost = 86;

            Console.WriteLine("Enter width in meters:");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter length in meters:");
            double length = Convert.ToDouble(Console.ReadLine());

            double squareMeter = width * length;

            Console.WriteLine("Enter cost per m2:");
            double costPerM2 = Convert.ToDouble(Console.ReadLine());

            double calculatedLaborCost = squareMeter / 20 * laborCost;

            double finalCost = width * length * costPerM2 + calculatedLaborCost;
            Console.WriteLine($"The cost is {finalCost}");
        }
    }
}
