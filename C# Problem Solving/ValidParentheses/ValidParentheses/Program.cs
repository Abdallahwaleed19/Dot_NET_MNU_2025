using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"'([)]' -> {IsValid("([)]")}");   
        Console.WriteLine($"'{{[]}}' -> {IsValid("{[]}")}");     
        Console.WriteLine($"'()' -> {IsValid("()")}");      
    }

    public static bool IsValid(string s)
    {
        var stack = new Stack<char>();
        var bracketPairs = new Dictionary<char, char>()
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };
        foreach (char c in s)
        {
            if (bracketPairs.ContainsKey(c))
            {
                if (stack.Count == 0 || stack.Pop() != bracketPairs[c])
                {
                    return false;
                }
            }
            else
            {
                stack.Push(c);
            }
        }
        return stack.Count == 0;
    }
}