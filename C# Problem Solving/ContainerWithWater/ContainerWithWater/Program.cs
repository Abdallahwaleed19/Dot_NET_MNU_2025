using System;

// This class contains the logic to solve the problem
public class Solution
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            int width = right - left;
            int currentHeight = Math.Min(height[left], height[right]);
            int currentArea = width * currentHeight;
            maxArea = Math.Max(maxArea, currentArea);

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return maxArea;
    }
}


public class Program
{

    public static void Main(string[] args)
    {
       
        Solution solver = new Solution();

        
        int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

     
        int result = solver.MaxArea(height);
        Console.WriteLine("Input: [1, 8, 6, 2, 5, 4, 8, 3, 7]");
        Console.WriteLine($"The maximum amount of water a container can store is: {result}");
    }
}