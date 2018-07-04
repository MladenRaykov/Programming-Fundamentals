using System;

namespace _17PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            for (char i = (char)first; i <= (char)second; i++)
            {
                Console.Write($"{i} ");// по-лесен вариант е направо тук да кастнем i към char, а горе да си ги оставим int
            }
        }
    }
}
