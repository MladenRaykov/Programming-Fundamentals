using System;
using System.Linq;

namespace _07MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int firstPosition = 0;
            int length = 1;
            long maxLength = 0;

            for (int i = nums.Length - 1; i > 0; i--)
            {

                if (nums[i] - nums[i - 1] >= 1)
                {
                    length++;
                }
                else
                {
                    length = 1;
                }
                if (length >= maxLength)
                {
                    maxLength = length;
                    firstPosition = i - 1;
                }

            }

            for (int i = firstPosition; i < maxLength + firstPosition; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
