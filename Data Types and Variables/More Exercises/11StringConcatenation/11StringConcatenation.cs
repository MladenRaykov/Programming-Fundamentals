using System;

namespace _11StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            string evenOdd = Console.ReadLine();
            int lines = int.Parse(Console.ReadLine());
            string message = "";

            for (int i = 1; i <= lines; i++)
            {
                string word = Console.ReadLine();
                if (evenOdd == "even" && i % 2 == 0)
                {
                    message += word + symbol;
                }
                else if (evenOdd == "odd" && i % 2 != 0)
                {
                    message += word + symbol;
                }
            }
            Console.WriteLine(message.Remove(message.Length - 1));
        }
    }
}
