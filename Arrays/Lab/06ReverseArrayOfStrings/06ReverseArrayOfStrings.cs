using System;
using System.Linq;

namespace _06ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console
                .ReadLine()
                .Split(' ')
                .ToArray();
            string[] reversed = arr.Reverse().ToArray();
            Console.WriteLine(String.Join(" ", reversed));
        }
    }
}
