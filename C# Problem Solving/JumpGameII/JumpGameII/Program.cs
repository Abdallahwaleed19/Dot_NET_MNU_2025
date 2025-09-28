using System; // Required for Console.WriteLine and Math.Max

// This class contains the logic to solve the problem
public class Solution
{
    public int Jump(int[] nums)
    {
        // If the array has only one element or is empty, no jumps are needed.
        if (nums == null || nums.Length <= 1)
        {
            return 0;
        }

        // 'jumps' counts the minimum jumps needed.
        int jumps = 0;
        // 'currentEnd' marks the end of the range covered by the current jump.
        // Initially, we are at index 0, so the current jump covers up to index 0.
        int currentEnd = 0;
        // 'farthest' tracks the maximum index reachable from any point within the current jump's range.
        // Initially, from index 0, the farthest we can reach is nums[0].
        int farthest = 0;

        // We iterate through the array. We stop at 'nums.Length - 2' because
        // if 'farthest' already covers or surpasses 'nums.Length - 1',
        // we don't need to make another jump from the last element.
        for (int i = 0; i < nums.Length - 1; i++)
        {
            // Update the farthest point we can reach from the current position 'i'.
            // This is 'i' plus the maximum jump length from 'i'.
            farthest = Math.Max(farthest, i + nums[i]);

            // If the current index 'i' has reached the 'currentEnd' of our previous jump,
            // it means we must make a new jump.
            if (i == currentEnd)
            {
                jumps++; // Increment the total number of jumps.
                // The 'currentEnd' for the *next* jump is now the 'farthest' point
                // we could reach from anywhere within the *previous* jump.
                currentEnd = farthest;
            }
        }

        // The total number of jumps required to reach the last index.
        return jumps;
    }
}

// This class provides the entry point for the application for testing purposes.
public class Program
{
    public static void Main(string[] args)
    {
        // Create an instance of the Solution class
        Solution solver = new Solution();

        // --- Test Cases ---
        int[] nums1 = { 2, 3, 1, 1, 4 }; // Example 1
        int result1 = solver.Jump(nums1);
        Console.WriteLine($"Input: [{string.Join(",", nums1)}], Output: {result1} (Expected: 2)");

        int[] nums2 = { 2, 3, 0, 1, 4 }; // Example 2
        int result2 = solver.Jump(nums2);
        Console.WriteLine($"Input: [{string.Join(",", nums2)}], Output: {result2} (Expected: 2)");

        int[] nums3 = { 1, 1, 1, 1 }; // Another common case
        int result3 = solver.Jump(nums3);
        Console.WriteLine($"Input: [{string.Join(",", nums3)}], Output: {result3} (Expected: 3)");

        int[] nums4 = { 1 }; // Base case, already at end
        int result4 = solver.Jump(nums4);
        Console.WriteLine($"Input: [{string.Join(",", nums4)}], Output: {result4} (Expected: 0)");

        int[] nums5 = { 0 }; // Edge case where no jump is possible but length is 1
        int result5 = solver.Jump(nums5);
        Console.WriteLine($"Input: [{string.Join(",", nums5)}], Output: {result5} (Expected: 0)");

        int[] nums6 = { 7, 0, 9, 6, 9, 6, 9, 6, 1, 7, 9, 0, 3, 5, 9, 9, 9, 1, 10, 0, 6, 5, 7, 6, 8, 9, 4, 4, 6, 0, 0, 5, 3, 9, 6, 3, 8, 7, 4, 1, 0, 0, 0, 0, 4, 5, 3, 1, 1, 1, 5, 4, 8, 0, 7, 7, 4, 4, 0, 0, 5, 9, 4, 3, 3, 4, 7, 6, 3, 6, 5, 7, 2, 3, 9, 3, 1, 3, 1, 1, 5, 6, 6, 6, 0, 8, 2, 9, 1, 8, 8, 0, 9, 9, 6, 8, 8, 8, 2, 9 };
        int result6 = solver.Jump(nums6);
        Console.WriteLine($"Input: Long array, Output: {result6} (Expected: 3)");


        Console.ReadKey(); // Keep console open
    }
}