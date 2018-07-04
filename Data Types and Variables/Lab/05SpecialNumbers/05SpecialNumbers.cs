using System;

namespace _05SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int specialNum = i;
                Console.Write(i + " -> ");

                int sum = 0;
                while (specialNum > 0)
                {
                    sum += specialNum % 10;
                    specialNum = specialNum / 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.Write("True");
                }
                else
                {
                    Console.Write("False");
                }
                Console.WriteLine();
            }
        }
    }
}
