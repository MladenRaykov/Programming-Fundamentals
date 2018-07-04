using System;
using System.Linq;

namespace _4TripleSum
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
            bool notFound = true;
            
            for (int a = 0; a < arr.Length; a++)
            {
                for (int b = 0; b < arr.Length; b++)
                {
                    for (int c = 0; c < arr.Length; c++)
                    {
                        if (a >= 0 && a < b && b < arr.Length && arr[c] == arr[a] + arr[b])
                        {
                            Console.WriteLine($"{arr[a]} + {arr[b]} == {arr[c]}");
                            notFound = false;
                            break;
                        }
                    }
                }
            }
            if (notFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
