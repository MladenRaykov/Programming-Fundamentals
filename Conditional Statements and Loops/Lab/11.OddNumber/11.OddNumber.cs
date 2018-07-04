using System;

namespace _11.OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                int num = Math.Abs(int.Parse(Console.ReadLine()));
                if (num % 2 != 0)
                {
                    Console.WriteLine($"The number is: {num}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an odd number.");
                }
            }
        }
    }
}