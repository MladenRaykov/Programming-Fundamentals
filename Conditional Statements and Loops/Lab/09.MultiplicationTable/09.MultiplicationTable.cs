using System;

namespace _09.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum = number * i;
                Console.WriteLine($"{number} X {i} = {sum}");
            }
        }
    }
}
/* int i = 1;
 * while (i <= 10)
 * {
 *  Console.WriteLine($"{number} X {i} = {number + i}");
 *  i++;
 * }
 */