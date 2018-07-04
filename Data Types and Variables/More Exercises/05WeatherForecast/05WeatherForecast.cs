using System;

namespace _05WeatherForecast
{
    class Program
    {
        static void Main(string[] args)

        {
            try
            {
                long number = long.Parse(Console.ReadLine());

                if (number >= -128 && number <= 127)
                {
                    Console.WriteLine("Sunny");
                }
                else if (number >= -2147483648 && number <= 2147483647)
                {
                    Console.WriteLine("Cloudy");
                }
                else
                {
                    Console.WriteLine("Windy");
                }
            }
            catch
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
