using System;
using System.Linq;

namespace _09IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            foreach (var letter in word)
            {
                int index = letter - 97;
                Console.WriteLine($"{letter} -> {index}");
            }
        }
    }
}
