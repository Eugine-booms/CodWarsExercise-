using System;

using System.Net;
using System.Linq;
using System.Collections.Generic;

namespace Solution
{

    public class Sudoku
    {
        public static string DoneOrNot(int[][] board)
        {
            int i=0, j = 0;
            int rowSum=0, collumSum = 0;
            int[,] sum = new int[3, 9];
            for (i = 0; i < board.Length; i++)
            {
                for (j = 0; j < board[i].Length; j++)
                {
                    sum[0, j] += board[i][j];
                    sum[1,i] += board[i][j];
                    if (0 <=i && i <= 2)
                    {
                        if (0 <= j && j <= 2) sum[2, 0] += board[i][j];
                        if (3 <= j && j <= 5) sum[2, 1] += board[i][j];
                        if (6 <= j && j <= 8) sum[2, 2] += board[i][j];
                    }
                    if (3 <= i && i <= 5)
                    {
                        if (0 <= j && j <= 2) sum[2, 3] += board[i][j];
                        if (3 <= j && j <= 5) sum[2, 4] += board[i][j];
                        if (6 <= j && j <= 8) sum[2, 5] += board[i][j];
                    }
                    if (6 <= i && i <= 8)
                    {
                        if (0 <= j && j <= 2) sum[2, 6] += board[i][j];
                        if (3 <= j && j <= 5) sum[2, 7] += board[i][j];
                        if (6 <= j && j <= 8) sum[2, 8] += board[i][j];
                    }
                }
            }
            int count = 0;
            foreach (int f in sum)
            {
                count++;
                if (f != 45)
                    return "Try again!";
            }
            return "Finished!";

            //your code here
        }
    }
}