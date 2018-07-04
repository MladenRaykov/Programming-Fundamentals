using System;

namespace _09MakeAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string word = "";

            for (int i = 0; i < lines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                word += letter;
            }
            Console.WriteLine($"The word is: {word}");
        }
    }
}
