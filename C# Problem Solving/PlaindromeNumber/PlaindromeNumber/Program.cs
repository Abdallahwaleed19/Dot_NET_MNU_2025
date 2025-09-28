using System;
namespace PlaindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 121; // Example input
            bool isPalindrome = IsPalindrome(number);
            Console.WriteLine($"{number} is palindrome: {isPalindrome}");
        }
        static bool IsPalindrome(int x)
        {
            // Negative numbers are not palindrome
            if (x < 0) return false;
            int original = x;
            int reversed = 0;
            while (x > 0)
            {
                int digit = x % 10;
                reversed = reversed * 10 + digit;
                x /= 10;
            }
            return original == reversed;
        }
    }
}