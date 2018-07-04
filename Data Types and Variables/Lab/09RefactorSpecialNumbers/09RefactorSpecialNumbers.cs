using System;

namespace _09RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()); // преписах я, но не я разбрах!!!
            int digitsSum = 0;
            int currentNum = 0;
            bool isSpecial = false;
            for (int i = 1; i <= num; i++)
            {
                currentNum = i;
                while (i > 0)
                {
                    digitsSum += i % 10;
                    i = i / 10;
                }
                isSpecial = (digitsSum == 5) || (digitsSum == 7) || (digitsSum == 11);
                Console.WriteLine($"{currentNum} -> {isSpecial}");
                digitsSum = 0;
                i = currentNum;
            }

        }
    }
}
