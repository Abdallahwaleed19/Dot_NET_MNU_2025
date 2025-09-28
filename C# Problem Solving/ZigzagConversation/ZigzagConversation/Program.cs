using System;
namespace ZigzagConversation
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "PAYPALISHIRING";
            int numRows = 3;
            Solution solution = new Solution();
            string result = solution.Convert(s, numRows);
            Console.WriteLine(result); // Output: "PAHNAPLSIIGYIR"

        }
        public string Convert(string s, int numRows)
        {
            if (numRows == 1 || s.Length <= numRows)
                return s;
            string[] rows = new string[Math.Min(numRows, s.Length)];
            int currentRow = 0;
            bool goingDown = false;
            foreach (char c in s)
            {
                rows[currentRow] += c;
                if (currentRow == 0 || currentRow == numRows - 1)
                    goingDown = !goingDown;
                currentRow += goingDown ? 1 : -1;
            }
            string result = string.Empty;
            foreach (string row in rows)
            {
                result += row;
            }
            return result;
        }

    }

}