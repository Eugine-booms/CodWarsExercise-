using System;

namespace Solution
{
    public class Matrix
    {
        public static int Determinant(int[][] matrix)
        {
            int summ=0;
            PrintMatrix(matrix);
            if (matrix.Length == 1 && matrix[0].Length == 1) return matrix[0][0];
            if (matrix.Length == 2 && matrix[0].Length == 2) return ((matrix[0][0] * matrix[1][1]) - (matrix[0][1] * matrix[1][0]));
            for (var k = 0; k < matrix.Length; k++)
            {
                int[][] subMatrix = new int[matrix.Length - 1][];
                for (int i = 0; i < matrix.Length - 1; i++)
                {
                    int r = 0;
                    subMatrix[i]= new int[matrix.Length-1];
                    for (int j = 0; j < matrix.Length; j++)
                    {
                       j= (j == k) ? ++j : j;
                        if (j== matrix.Length) break;
                            subMatrix[i][r] = matrix[i + 1][j];
                        r++;
                    }
                }
                summ += (Determinant(subMatrix) *matrix[0][k]* ((k+1)%2>0?1:-1));
                Console.WriteLine();
                Console.WriteLine("summ="+summ);
                Console.WriteLine();
            }

            // Your code here!
            return summ;
        }
        public static void PrintMatrix(int[][] matrix)
        {
            Console.WriteLine("////////////////////////////////////");
            for (int i = 0; i < matrix.Length ; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("////////////////////////////////////");
        }
    }
}