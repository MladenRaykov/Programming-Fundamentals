using System;
using System.Linq;

namespace _08MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(' ')
                                   .Select(int.Parse)
                                   .ToArray();
            int counter = 0;
            int counterMax = 0;
            int frequentNum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        counter++;
                    }
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        frequentNum = numbers[i];
                    }
                }
                counter = 1;
            }
            Console.WriteLine(frequentNum);
        }
    }
}
