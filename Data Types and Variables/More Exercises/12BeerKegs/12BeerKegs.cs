using System;

namespace _12BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            double volume = 0;
            double maxVolume = 0;
            string biggestKeg = "";
            for (int i = 1; i <= lines; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    biggestKeg = model;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
