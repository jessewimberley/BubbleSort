﻿using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 1, 2, 3, 4, 6, 8, 9, 7 };
            int temp;
            for (int j = 0; j < nums.Length - 1; j++)
            {
                int canary = 0;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        temp = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = temp;
                        canary = 1;
                    }
                }
                if(canary == 0) { break; }
            }
        }
    }
}