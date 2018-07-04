using System;
using System.Linq;

namespace _03FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int k = numbers.Length / 4;
            int[] upper = new int[numbers.Length / 2];
            int[] lower = new int[numbers.Length / 2];
            int[] sum = new int[numbers.Length / 2];
            for (int i = 0; i < lower.Length; i++)
            {
                lower[i] = numbers[k + i];
            }
            for (int i = 0; i < k; i++)
            {
                upper[i] = numbers[k - i - 1];
            }
            for (int i = 0; i < k; i++)
            {
                upper[i + k] = numbers[upper.Length + k * 2 - i - 1];
            }

            for (int i = 0; i < lower.Length; i++)
            {
                sum[i] = upper[i] + lower[i];
            }
            Console.WriteLine(string.Join(" ", sum));

            /*
             * int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = numbers.Length / 4;
            int[] firstRow = new int[k * 2];
            int[] secondRow = new int[k * 2];


            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < k)
                {
                    firstRow[i] = numbers[k - i - 1];
                }
                else if (i >= k && i < 3 * k)
                {
                    secondRow[i - k] = numbers[i];
                }
                else
                {
                    firstRow[i - 2 * k] = numbers[(numbers.Length - i + k * 3)];
                }
            }
            Console.WriteLine(string.Join(" ", firstRow));
            */
        }
    }
}
