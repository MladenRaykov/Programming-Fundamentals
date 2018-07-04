using System;
using System.Linq;

namespace _06MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int num = 0;
            int length = 1;
            int maxLength = 0;
            for (int i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i] == nums[i - 1])
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
                    num = nums[i];
                }
            }

            int[] bestNum = new int[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                bestNum[i] = num;
            }

            Console.WriteLine(string.Join(" ", bestNum));
        }
    }
}
