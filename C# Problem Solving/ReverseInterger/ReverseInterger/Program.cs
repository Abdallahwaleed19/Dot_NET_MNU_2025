using System;

namespace ReverseInteger
{
    class Program
    {
        public int Reverse(int x)
        {
            bool isNegative = x < 0;
            string numberString = Math.Abs((long)x).ToString();
            char[] charArray = numberString.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            if (int.TryParse(reversedString, out int result))
            {
                return isNegative ? -result : result;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int test1 = 123;
            Console.WriteLine($"Original: {test1}, Reversed: {p.Reverse(test1)}"); 

            int test2 = -123;
            Console.WriteLine($"Original: {test2}, Reversed: {p.Reverse(test2)}"); 

            int test3 = 120;
            Console.WriteLine($"Original: {test3}, Reversed: {p.Reverse(test3)}"); 

        }
    }
}