using System;


    class Program
    {
        static void Main(string[] args)
        {
            int target = 9;
            int[] nums = [2, 7, 11, 15];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                    Console.WriteLine($"[{nums[i]}, {nums[j]}]");
                    }

                }

            }
        }
    }