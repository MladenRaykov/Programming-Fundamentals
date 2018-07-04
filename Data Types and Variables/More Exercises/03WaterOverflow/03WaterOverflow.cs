using System;

namespace _03WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int waterTank = 0;
            for (int i = 0; i < lines; i++)
            {
                int quantity = int.Parse(Console.ReadLine());
                if (waterTank + quantity > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    waterTank += quantity;
                }

            }
            Console.WriteLine($"{waterTank}");
        }
    }
}
