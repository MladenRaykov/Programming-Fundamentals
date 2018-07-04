using System;

namespace _04SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size + 1];
            bool[] isPrime = new bool[size + 1];

            primeNums = primeNums.Select(p => p = true).ToArray();
            isPrime[0] = false;
            isPrime[1] = false;

            for (int i = 0; i <= size; i++)
            {
                if (isPrime[i])
                {
                    Console.Write(numbers[i] + " ");
                    for (int p = i * 2; p <= size; p+i)
                    {
                        isPrime[j] = false;
                    }
                }
            }
        }
    }
}
