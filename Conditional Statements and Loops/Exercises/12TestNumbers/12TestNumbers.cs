using System;

namespace _12TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            for (int i = num1; i >= 1; i--)
            {
                for (int k = 1; k <= num2; k++)
                {
                    sum += (k * i) * 3;
                    counter++;
                    if (sum >= num3)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {num3}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
