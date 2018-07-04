using System;

namespace _11ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());

            double timeInSeconds = (hours * 60 + minutes) * 60 + seconds;

            double speedInMetersPerSec = distance / timeInSeconds;
            double speedInKmPerHour = (distance / 1000) / (timeInSeconds / 60 / 60);
            double speedInMilesPerHour = (distance / 1609) / (timeInSeconds / 60 / 60);
            Console.WriteLine($"{speedInMetersPerSec:f6}");
            Console.WriteLine(speedInKmPerHour);
            Console.WriteLine(speedInMilesPerHour);
        }
    }
}
