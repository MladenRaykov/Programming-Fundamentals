using System;

namespace _10.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int sum = 0;

            if (multiplier > 10)
            {
                sum = number * multiplier;
                Console.WriteLine($"{number} X {multiplier} = {sum}");
                return;
            }
            for (int i = multiplier; i <= 10; i++)
            {
                sum = number * i;
                Console.WriteLine($"{number} X {i} = {sum}");
            }

        }
    }
}