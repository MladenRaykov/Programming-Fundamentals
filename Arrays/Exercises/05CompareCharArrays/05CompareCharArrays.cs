using System;
using System.Linq;

namespace _05CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word1 = Console
                .ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
            char[] word2 = Console
                .ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
            bool[] isEqual = new bool[Math.Min(word1.Length, word2.Length)];

            for (int i = 0; i < isEqual.Length; i++)
            {
                if (word1[i] == word2[i])
                {
                    isEqual[i] = true;
                }
                else
                {
                    break;
                }
            }
            if (isEqual[isEqual.Length - 1])
            {
                if (word1.Length <= word2.Length)
                {
                    Console.WriteLine(string.Join("", word1));
                    Console.WriteLine(string.Join("", word2));
                }
                else
                {
                    Console.WriteLine(string.Join("", word2));
                    Console.WriteLine(string.Join("", word1));
                }
            }
            else
            {
                if (word1[0] > word2[0])
                {
                    Console.WriteLine(string.Join("", word2));
                    Console.WriteLine(string.Join("", word1));
                }
                else
                {
                    Console.WriteLine(string.Join("", word1));
                    Console.WriteLine(string.Join("", word2));
                }
            }
        }
    }
}
