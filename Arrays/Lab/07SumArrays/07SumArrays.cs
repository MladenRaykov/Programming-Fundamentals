using System;
using System.Linq;

namespace _07SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] arr2 = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int len1 = arr1.Length;
            int len2 = arr2.Length;
            int len3 = Math.Max(len1, len2);
            int[] arr3 = new int[len3];

            for (int i = 0; i < len3; i++)
            {
                arr3[i] = arr1[i % len1] + arr2[i % len2];
            }
            Console.WriteLine(String.Join(" ", arr3));
        }
    }
}
