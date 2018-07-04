using System;

namespace _14MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());
            char symbol3 = char.Parse(Console.ReadLine());

            for (char i = symbol1; i <= symbol2; i++)
            {
                for (char k = symbol1; k <= symbol2; k++)
                {
                    for (char m = symbol1; m <= symbol2; m++)
                    {
                        if (i != symbol3 && k != symbol3 && m != symbol3)
                        {
                            Console.Write($"{i}{k}{m} ");
                        }
                    }
                }
            }
        }
    }
}
