using System;

namespace _11._5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num2 - num1 < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = num1; i <= num2; i++)
                {
                    for (int k = num1; k <= num2; k++)
                    {
                        for (int m = num1; m <= num2; m++)
                        {
                            for (int o = num1; o <= num2; o++)
                            {
                                for (int p = num1; p <= num2; p++)
                                {
                                    bool isValid = num1 <= i && i < k && k < m && m < o && o < p && p <= num2;
                                    if (isValid)
                                    {
                                        Console.WriteLine($"{i} {k} {m} {o} {p}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
