using System;
class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 3, 5, 6 };
        int target = 5;
        int result = SearchInsert(nums, target);
        Console.WriteLine(result); // Output: 2
    }
    static int SearchInsert(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return left;
    }
}