using System;

namespace _15NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());
            int healthPesho = 100;
            int healthGosho = 100;
            int counter = 0;

            while (true)
            {
                counter++;
                if (counter % 2 == 0)
                {
                    healthPesho -= damageGosho;
                    if (healthPesho <= 0)
                    {
                        Console.WriteLine($"Gosho won in {counter}th round.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");
                    }
                }
                else
                {
                    healthGosho -= damagePesho;
                    if (healthGosho <= 0)
                    {
                        Console.WriteLine($"Pesho won in {counter}th round.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");
                    }
                }
                if (counter % 3 == 0)
                {
                    healthGosho += 10;
                    healthPesho += 10;
                }
            }
        }
    }
}
