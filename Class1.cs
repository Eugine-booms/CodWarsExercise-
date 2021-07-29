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
            int[] sum = new int[9];
            for (i = 0; i < board.Length; i++)
            {
                if (board[i].Sum() != 45 || board.Select(x => x[i]).Sum() != 45)
                    return "Try again!";
                for (j = 0; j < board[i].Length; j++)
                {
                    if (0 <=i && i <= 2)
                    {
                        if (0 <= j && j <= 2) sum[0] += board[i][j];
                        if (3 <= j && j <= 5) sum[1] += board[i][j];
                        if (6 <= j && j <= 8) sum[2] += board[i][j];
                    }
                    if (3 <= i && i <= 5)
                    {
                        if (0 <= j && j <= 2) sum[3] += board[i][j];
                        if (3 <= j && j <= 5) sum[4] += board[i][j];
                        if (6 <= j && j <= 8) sum[5] += board[i][j];
                    }
                    if (6 <= i && i <= 8)
                    {
                        if (0 <= j && j <= 2) sum[6] += board[i][j];
                        if (3 <= j && j <= 5) sum[7] += board[i][j];
                        if (6 <= j && j <= 8) sum[8] += board[i][j];
                    }
                }
            }
            foreach (int f in sum)
            {
                if (f != 45)
                    return "Try again!";
            }
            return "Finished!";

            //your code here
        }
    }
}