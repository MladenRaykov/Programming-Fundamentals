using System;
using System.Linq;

namespace _10PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(' ')
                                   .Select(int.Parse)
                                   .ToArray();
            int diff = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = i; k < numbers.Length; k++)
                {
                    if (Math.Abs(numbers[i] - numbers[k]) == diff)
                    {
                        counter++;
                    }
                }

            }
            Console.WriteLine(counter);
        }
    }
}
