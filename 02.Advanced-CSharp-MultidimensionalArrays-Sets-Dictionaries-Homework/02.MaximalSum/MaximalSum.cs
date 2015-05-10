using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaximalSum
{
    internal class MaximalSum
    {
        private static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                input = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int maxSum = int.MinValue;
            int[,] platform = new int[3, 3];

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int sum = FindSum(matrix, row, col);
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        platform = FillPlatform(matrix, row, col);
                    }

                }
            }

            Console.WriteLine("Sum = " + maxSum);
            PrintMatrix(platform);

        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static int FindSum(int[,] matrix, int row, int col)
        {
            int sum = 0;
            for (int i = row; i < row + 3; i++)
            {
                for (int j = col; j < col + 3; j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }

        private static int[,] FillPlatform(int[,] matrix, int row, int col)
        {
            int[,]platform = new int[3,3];

            for (int i = row, k = 0; i < row + 3; i++, k++)
            {
                for (int j = col, l = 0 ; j < col + 3; j++, l++)
                {
                    platform[k, l] = matrix[i, j];
                }
            }
            return platform;
        }
    }
}
