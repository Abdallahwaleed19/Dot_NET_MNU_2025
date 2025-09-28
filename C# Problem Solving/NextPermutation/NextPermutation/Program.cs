using System;

// This class contains the logic to solve the problem
public class Solution
{
    public void NextPermutation(int[] nums)
    {
        if (nums == null || nums.Length <= 1) return;

        int i = nums.Length - 2;
        while (i >= 0 && nums[i] >= nums[i + 1])
        {
            i--;
        }

        if (i >= 0)
        {
            int j = nums.Length - 1;
            while (nums[j] <= nums[i])
            {
                j--;
            }
            Swap(nums, i, j);
        }

        Reverse(nums, i + 1);
    }

    private void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

    private void Reverse(int[] nums, int start)
    {
        int i = start;
        int j = nums.Length - 1;
        while (i < j)
        {
            Swap(nums, i, j);
            i++;
            j--;
        }
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
        int[] nums = { 1, 2, 3 };

        Console.Write("Original array: ");
        PrintArray(nums);

        // 3. Call the NextPermutation method (modifies the array in-place)
        solver.NextPermutation(nums);

        // 4. Print the final result
        Console.Write("Next permutation: ");
        PrintArray(nums); // Expected: [1, 3, 2]
    }

    // Helper function to print an array
    public static void PrintArray(int[] nums)
    {
        Console.WriteLine("[" + string.Join(",", nums) + "]");
    }
}