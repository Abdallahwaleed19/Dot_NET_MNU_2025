using System;
using System.Collections.Generic;

// This class contains the logic to solve the problem
public class Solution
{
    public int LongestValidParentheses(string s)
    {
        int maxLength = 0;
        var stack = new Stack<int>();

        // Push -1 as an initial index to act as a base for calculations.
        stack.Push(-1);

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack.Push(i);
            }
            else
            { // s[i] == ')'
                stack.Pop();

                if (stack.Count == 0)
                {
                    stack.Push(i);
                }
                else
                {
                    maxLength = Math.Max(maxLength, i - stack.Peek());
                }
            }
        }

        return maxLength;
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

        // 2. Define the sample input string from the example
        string s = ")()())";

        // 3. Call the LongestValidParentheses method with your input
        int result = solver.LongestValidParentheses(s);

        // 4. Print the final result to the console
        Console.WriteLine($"Input string: \"{s}\"");
        Console.WriteLine($"Length of the longest valid parentheses substring: {result}"); // Expected: 4
    }
}