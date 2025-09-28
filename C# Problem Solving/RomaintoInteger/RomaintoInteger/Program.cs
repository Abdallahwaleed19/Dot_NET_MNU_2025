using System;
using System.Collections.Generic;

public class Solution
{
    public int RomanToInt(string s)
    {
        var romanMap = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int total = romanMap[s[s.Length - 1]];

        for (int i = s.Length - 2; i >= 0; i--)
        {
            if (romanMap[s[i]] < romanMap[s[i + 1]])
            {
                total -= romanMap[s[i]];
            }
            else
            {
                total += romanMap[s[i]];
            }
        }

        return total;
    }
}


public class Program
{
    
    public static void Main(string[] args)
    {

        Solution solver = new Solution();

     
        string romanNumeral = "MCMXCIV";

        
        int result = solver.RomanToInt(romanNumeral);

        // 4. Print the final result to the console
        Console.WriteLine($"The Roman numeral \"{romanNumeral}\" is equal to {result}.");
    }
}