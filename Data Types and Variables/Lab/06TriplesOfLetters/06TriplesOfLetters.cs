using System;

namespace _06TriplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 'a'; i < 'a' + n; i++)
            {
                for (int k = 'a'; k < 'a' + n; k++)
                {
                    for (int m = 'a'; m < 'a' + n; m++)
                    {
                        Console.WriteLine($"{(char)i}{(char)k}{(char)m}");
                    }
                }
            }
        }
    }
}