using System;
using System.Linq;

namespace _02RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] sum = new int[nums.Length];

            for (int i = 0; i < rotations; i++)
            {
                Shift(nums);
                Sum(sum, nums);
            }
            Console.WriteLine(string.Join(" ", sum));
        }

        private static void Sum(int[] sum, int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                sum[i] += nums[i];
            }
        }

        private static void Shift(int[] arr)
        {

            int last = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = last;
        }
    }
}
