using System;
namespace MedianofTwoSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4 };
            double result = FindMedianSortedArrays(nums1, nums2);
            Console.WriteLine(result);
        }
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;
            if (m > n)
            {
                return FindMedianSortedArrays(nums2, nums1);
            }
            int imin = 0, imax = m, halfLen = (m + n + 1) / 2;
            while (imin <= imax)
            {
                int i = (imin + imax) / 2;
                int j = halfLen - i;
                if (i < m && nums2[j - 1] > nums1[i])
                {
                    imin = i + 1; // i is too small
                }
                else if (i > 0 && nums1[i - 1] > nums2[j])
                {
                    imax = i - 1; // i is too big
                }
                else
                {
                    // i is perfect
                    int maxOfLeft;
                    if (i == 0) { maxOfLeft = nums2[j - 1]; }
                    else if (j == 0) { maxOfLeft = nums1[i - 1]; }
                    else { maxOfLeft = Math.Max(nums1[i - 1], nums2[j - 1]); }
                    if ((m + n) % 2 == 1)
                    {
                        return maxOfLeft; // Odd case
                    }
                    int minOfRight;
                    if (i == m) { minOfRight = nums2[j]; }
                    else if (j == n) { minOfRight = nums1[i]; }
                    else { minOfRight = Math.Min(nums1[i], nums2[j]); }
                    return (maxOfLeft + minOfRight) / 2.0; // Even case
                }
            }
            throw new ArgumentException("Input arrays are not sorted or invalid.");
        }
    }
}