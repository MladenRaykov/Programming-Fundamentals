using System;

namespace _02ReverseArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int[] arr = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }

            // вариант без втори цикъл:
            // int [] reversed = arr.Reverse().ToArray();
            // Console.WriteLine(string.Join(" ", reversed));

            // трети вариант:
            // Array.Reverse(arr);
            // ConsoleWriteLine(string.Join(" ", arr));

        }
    }
}
