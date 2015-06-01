using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P2
{
    class P2
    {
        static void Main(string[] args)
        {
            int[] dimensions = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            string snake = Console.ReadLine();
            int[] shotParams = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int cols = dimensions[1];
            int rows = dimensions[0];

            char[,] matrix = new char[rows, cols];

            FillMatrix(rows, cols, snake, matrix);
            Shooot(shotParams, matrix);
            DropChars(matrix);
            PrintMatrix(matrix);

        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void Shooot(int[] param, char [,] matrix)
        {
            int r = param[2];
            int cY = param[0];
            int cX = param[1];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    double x = Math.Sqrt((j - cX) * (j - cX) + (i - cY) * (i - cY));
                    if (x <= r)
                    {
                        matrix[i, j] = ' ';
                    }
                }
            }
        }

        private static void DropChars(char[,] matrix)
        {
            for (int i = matrix.GetLength(0) - 2; i >= 0; i--)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    bool canFall = true;
                    int row = i + 1;
                    while (canFall)
                    {
                        if (matrix[row, col] == ' ')
                        {
                            matrix[row, col] = matrix[row - 1, col];
                            matrix[row - 1, col] = ' ';
                            row++;
                            if (row == matrix.GetLength(0))
                            {
                                canFall = false;
                            }
                        }
                        else
                        {
                            canFall = false;
                        }
                    }
                }
            }
        }

        private static void FillMatrix(int rows, int cols, string input, char[,] matrix)
        {
            int index = 0;
            int rowCount = 0;
            for (int row = rows - 1; row >= 0; row--, rowCount --)
            {
                if (rowCount%2 == 0)
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        if (index >= input.Length)
                        {
                            index = 0;
                            matrix[row, col] = input[index];
                        }
                        else
                        {
                            matrix[row, col] = input[index];
                        }
                        index++;
                    }
                }
                else
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (index >= input.Length)
                        {
                            index = 0;
                            matrix[row, col] = input[index];
                        }
                        else
                        {
                            matrix[row, col] = input[index];
                        }
                        index++;
                    }
                }
            }
        }
    }
}
