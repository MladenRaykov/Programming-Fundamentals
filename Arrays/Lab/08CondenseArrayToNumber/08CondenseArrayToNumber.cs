using System;
using System.Linq;

namespace _08CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] condensed = new int[arr.Length - 1];

            if (arr.Length == 1)
            {
                Console.WriteLine(arr[0]);
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < condensed.Length - i; k++)
                {
                    condensed[k] = arr[k] + arr[k + 1];
                }
                arr = condensed;
            }
            Console.WriteLine(condensed[0]);
        }
    }
}
