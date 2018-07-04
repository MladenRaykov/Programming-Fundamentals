using System;

namespace _13GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = num2; i >= num1; i--)
            {
                for (int k = num2; k >= num1; k--)
                {
                    if (i + k == num3)
                    {
                        Console.WriteLine($"Number found! {i} + {k} = {num3}");
                        return;
                    }
                    counter++;
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {num3}");
        }
    }
}
