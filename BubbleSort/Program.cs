using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 1, 2, 3, 4, 6, 8, 9, 7 };
            int temp;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    temp = nums[i];
                    nums[i] = nums[i + 1];
                    nums[i + 1] = temp;

                }
            }
    } }
}