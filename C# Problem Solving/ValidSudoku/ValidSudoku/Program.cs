using System;
using System.Collections.Generic;

// This class contains the logic to solve the problem
public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var boxes = new HashSet<char>[9];

        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                char val = board[r][c];

                if (val == '.')
                {
                    continue;
                }

                if (!rows[r].Add(val)) return false;
                if (!cols[c].Add(val)) return false;

                int boxIndex = (r / 3) * 3 + (c / 3);
                if (!boxes[boxIndex].Add(val)) return false;
            }
        }
        return true;
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

        // 2. Create the sample Sudoku board
        char[][] board = new char[][]
        {
            new char[] {'5','3','.','.','7','.','.','.','.'},
            new char[] {'6','.','.','1','9','5','.','.','.'},
            new char[] {'.','9','8','.','.','.','.','6','.'},
            new char[] {'8','.','.','.','6','.','.','.','3'},
            new char[] {'4','.','.','8','.','3','.','.','1'},
            new char[] {'7','.','.','.','2','.','.','.','6'},
            new char[] {'.','6','.','.','.','.','2','8','.'},
            new char[] {'.','.','.','4','1','9','.','.','5'},
            new char[] {'.','.','.','.','8','.','.','7','9'}
        };

        // 3. Call the IsValidSudoku method
        bool isValid = solver.IsValidSudoku(board);

        // 4. Print the final result
        Console.WriteLine("The provided Sudoku board is:");
        PrintBoard(board);
        Console.WriteLine($"Result: The board is {(isValid ? "Valid" : "Invalid")}.");
    }

    // Helper function to print the Sudoku board
    public static void PrintBoard(char[][] board)
    {
        for (int r = 0; r < 9; r++)
        {
            if (r % 3 == 0 && r != 0)
            {
                Console.WriteLine("---------------------");
            }
            for (int c = 0; c < 9; c++)
            {
                if (c % 3 == 0 && c != 0)
                {
                    Console.Write("| ");
                }
                Console.Write(board[r][c] + " ");
            }
            Console.WriteLine();
        }
    }
}