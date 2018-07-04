using System;
using System.Linq;

namespace _05RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console
                .ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            
            foreach (var num in numbers)
            {
                var rounded = Math.Round(num, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{num} => {rounded}");
            }
        }
    }
}
