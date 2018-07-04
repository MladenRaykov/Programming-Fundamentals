using System;

namespace _04TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            double initialValue = double.Parse(Console.ReadLine());
            double convertedValue = 0;
            string metricUnit = "";
            if (imperialUnit == "miles")
            {
                convertedValue = initialValue * 1.6;
                metricUnit = "kilometers";
            }
            else if (imperialUnit == "inches")
            {
                convertedValue = initialValue * 2.54;
                metricUnit = "centimeters";
            }
            else if (imperialUnit == "feet")
            {
                convertedValue = initialValue * 30;
                metricUnit = "centimeters";
            }
            else if (imperialUnit == "yards")
            {
                convertedValue = initialValue * 0.91;
                metricUnit = "meters";
            }
            else if (imperialUnit == "gallons")
            {
                convertedValue = initialValue * 3.8;
                metricUnit = "liters";
            }
            Console.WriteLine($"{initialValue} {imperialUnit} = {convertedValue:f2} {metricUnit}");
        }
    }
}
