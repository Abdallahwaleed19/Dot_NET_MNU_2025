using System;

// This class contains the logic to solve the problem
public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        int n = nums.Length;

        // Pass 1: Place each number in its correct "bucket" if possible
        for (int i = 0; i < n; i++)
        {
            while (nums[i] > 0 && nums[i] <= n && nums[i] != nums[nums[i] - 1])
            {
                int correctIndex = nums[i] - 1;

                // Swap nums[i] with the number at its correct index
                int temp = nums[i];
                nums[i] = nums[correctIndex];
                nums[correctIndex] = temp;
            }
        }

        // Pass 2: Find the first missing positive integer
        for (int i = 0; i < n; i++)
        {
            if (nums[i] != i + 1)
            {
                return i + 1;
            }
        }

        return n + 1;
    }
}

// This class provides the entry point for the application
public class Program
{
    // The 'Main' method is the starting point for execution
    public static void Main(string[] args)
    {
        // 1. Create an instance of your Solution class
        Solution solver = new Solution();

        // 2. Create the sample input array
        int[] nums = { 3, 4, -1, 1 };

        Console.Write("Original array: ");
        PrintArray(nums);

        // 3. Call the FirstMissingPositive method
        int result = solver.FirstMissingPositive(nums);

        // 4. Print the final results
        Console.Write("Array after in-place sort: ");
        PrintArray(nums); // Shows how the array was rearranged
        Console.WriteLine($"The first missing positive integer is: {result}"); // Expected: 2
    }

    // Helper function to print an array
    public static void PrintArray(int[] nums)
    {
        Console.WriteLine("[" + string.Join(",", nums) + "]");
    }
}