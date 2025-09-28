using System;
namespace LongSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "bbbbb";
            int result = LengthOfLongestSubstring(input);
            Console.WriteLine($"The length of the longest substring without repeating characters in '{input}' is: {result}");
        }
        static int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            int maxLength = 0;
            int left = 0;
            var charIndexMap = new System.Collections.Generic.Dictionary<char, int>();
            for (int right = 0; right < n; right++)
            {
                if (charIndexMap.ContainsKey(s[right]))
                {
                    left = Math.Max(charIndexMap[s[right]] + 1, left);
                }
                charIndexMap[s[right]] = right;
                maxLength = Math.Max(maxLength, right - left + 1);
            }
            return maxLength;
        }
    }
}