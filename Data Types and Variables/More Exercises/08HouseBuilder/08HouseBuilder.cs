using System;

namespace _08HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string price1 = Console.ReadLine();
            string price2 = Console.ReadLine();

            sbyte sbytePrice = 0;
            int intPrice = 0;
            long totalInt = 0;
            int totalSbyte = 0;

            if (sbyte.TryParse(price1, out sbytePrice))
            {
                totalSbyte = sbytePrice * 4;
                int.TryParse(price2, out intPrice);
                totalInt = intPrice * 10;
            }
            else if (sbyte.TryParse(price2, out sbytePrice))
            {
                totalSbyte = sbytePrice * 4;
                int.TryParse(price1, out intPrice);
                totalInt = (long)intPrice * 10;
            }
            long totalMaterials = totalInt + totalSbyte;
            Console.WriteLine(totalMaterials);

        }
    }
}
