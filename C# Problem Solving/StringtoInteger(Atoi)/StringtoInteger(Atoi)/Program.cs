using System;
namespace StringtoInteger_Atoi_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1337c0d3";
            int result = MyAtoi(str);
            Console.WriteLine(result); 
        }
        public static int MyAtoi(string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;
            int i = 0, sign = 1, result = 0;
            // Discard whitespaces in the beginning
            while (i < str.Length && str[i] == ' ')
                i++;
            // Check for sign
            if (i < str.Length && (str[i] == '+' || str[i] == '-'))
            {
                sign = (str[i] == '-') ? -1 : 1;
                i++;
            }
            // Convert number and avoid overflow
            while (i < str.Length && char.IsDigit(str[i]))
            {
                int digit = str[i] - '0';
                // Check for overflow
                if (result > (int.MaxValue - digit) / 10)
                    return sign == 1 ? int.MaxValue : int.MinValue;
                result = result * 10 + digit;
                i++;
            }
            return result * sign;
        }
    }
}