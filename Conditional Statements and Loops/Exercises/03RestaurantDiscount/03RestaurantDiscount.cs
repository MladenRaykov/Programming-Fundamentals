using System;

namespace _03RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double price = 0;
            string hall = "";

            if (groupSize <= 50)
            {
                price = 2500;
                hall = "Small Hall";
            }
            else if (groupSize <= 100)
            {
                price = 5000;
                hall = "Terrace";
            }
            else if (groupSize <= 120)
            {
                price = 7500;
                hall = "Great Hall";
            }
            if (package == "Normal")
            {
                price = (price + 500) - (price + 500) * 0.05;
            }
            else if (package == "Gold")
            {
                price = (price + 750) - (price + 750) * 0.1;
            }
            else
            {
                price = (price + 1000) - (price + 1000) * 0.15;
            }
            double pricePerPerson = price / groupSize;
            if (groupSize <= 120)
            {
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
