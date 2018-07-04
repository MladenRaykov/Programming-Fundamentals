using System;

namespace _03LastKNumbersSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] lastK = new long[lenght];
            lastK[0] = 1;

            for (int i = 1; i < lenght; i++)
            {
                for (int l = i; l >= i - k && l >= 0; l--)
                {
                    lastK[i] += lastK[l];
                }

            }
            Console.WriteLine(String.Join(" ", lastK));
        }
    }
}
