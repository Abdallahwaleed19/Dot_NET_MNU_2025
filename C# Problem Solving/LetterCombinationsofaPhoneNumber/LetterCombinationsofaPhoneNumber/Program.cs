using System;
using System.Collections.Generic;

// This class contains the logic to solve the problem
public class Solution
{
    private IList<string> result;
    private Dictionary<char, string> phoneMap;

    public IList<string> LetterCombinations(string digits)
    {
        result = new List<string>();

        if (string.IsNullOrEmpty(digits))
        {
            return result;
        }

        phoneMap = new Dictionary<char, string>
        {
            { '2', "abc" }, { '3', "def" }, { '4', "ghi" },
            { '5', "jkl" }, { '6', "mno" }, { '7', "pqrs" },
            { '8', "tuv" }, { '9', "wxyz" }
        };

        Backtrack(0, "", digits);

        return result;
    }

    private void Backtrack(int index, string currentCombination, string digits)
    {
        if (index == digits.Length)
        {
            result.Add(currentCombination);
            return;
        }

        char currentDigit = digits[index];
        string letters = phoneMap[currentDigit];

        foreach (char letter in letters)
        {
            Backtrack(index + 1, currentCombination + letter, digits);
        }
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        
        Solution solver = new Solution();

        
        string digits = "23";

        
        IList<string> combinations = solver.LetterCombinations(digits);

        
        Console.WriteLine($"Input: \"{digits}\"");
        Console.WriteLine("Output: [\"" + string.Join("\",\"", combinations) + "\"]");
    }
}