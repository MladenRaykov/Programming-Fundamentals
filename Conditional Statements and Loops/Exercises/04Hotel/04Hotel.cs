using System;

namespace _04Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceDouble = 0;
            double priceSuit = 0;

            if (month == "May" || month == "October")
            {
                priceStudio = 50;
                priceDouble = 65;
                priceSuit = 75;
                if (nights > 7)
                {
                    priceStudio -= priceStudio * 0.05;
                }
            }
            else if (month == "June" || month == "September")
            {
                priceStudio = 60;
                priceDouble = 72;
                priceSuit = 82;
                if (nights > 14)
                {
                    priceDouble -= priceDouble * 0.1;
                }
            }
            else
            {
                priceStudio = 68;
                priceDouble = 77;
                priceSuit = 89;
                if (nights > 14)
                {
                    priceSuit -= priceSuit * 0.15;
                }
            }
            double totalStudio = priceStudio * nights;
            double totalDouble = priceDouble * nights;
            double totalSuite = priceSuit * nights;
            if ((month == "September" || month == "October") && nights > 7)
            {
                totalStudio = priceStudio * nights - priceStudio;
            }
            Console.WriteLine($"Studio: {totalStudio:f2} lv.");
            Console.WriteLine($"Double: {totalDouble:f2} lv.");
            Console.WriteLine($"Suite: {totalSuite:f2} lv.");
        }
    }
}
