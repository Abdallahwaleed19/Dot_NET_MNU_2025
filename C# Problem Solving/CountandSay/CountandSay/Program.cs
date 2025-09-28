using System;
using System.Text;

// This class contains the logic to solve the problem
public class Solution
{
    public string CountAndSay(int n)
    {
        if (n == 1)
        {
            return "1";
        }

        string currentResult = "1";

        // Start from the 2nd term and build up to the n-th term
        for (int i = 2; i <= n; i++)
        {
            var nextResultBuilder = new StringBuilder();
            int j = 0;
            while (j < currentResult.Length)
            {
                char currentChar = currentResult[j];
                int count = 0;

                // Look ahead to count all consecutive occurrences of currentChar
                int k = j;
                while (k < currentResult.Length && currentResult[k] == currentChar)
                {
                    count++;
                    k++;
                }

                // Append the count and the character to the new string
                nextResultBuilder.Append(count);
                nextResultBuilder.Append(currentChar);

                // Move the main pointer past the group we just processed
                j = k;
            }
            // The newly built string is now our current result for the next iteration
            currentResult = nextResultBuilder.ToString();
        }

        return currentResult;
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

        // 2. Define the term 'n' you want to find
        int n = 4;

        // 3. Call the CountAndSay method with your input
        string result = solver.CountAndSay(n);

        // 4. Print the final result to the console
        Console.WriteLine($"The {n}th term of the Count-and-Say sequence is: {result}"); // Expected: "1211"
    }
}