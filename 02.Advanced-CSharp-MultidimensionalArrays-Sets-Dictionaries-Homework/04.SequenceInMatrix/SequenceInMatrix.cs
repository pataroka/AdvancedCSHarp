using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SequenceInMatrix
{
    class SequenceInMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter matrix's rows and columns separated by a space:");
            string[] input = Console.ReadLine().Split(' ');
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);
            Console.WriteLine("Fill the matrix with strings in the order you want them to appear in the matrix(each row on a separate line) - separate them by a space:");

            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                input = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            List<string> bestString = new List<string>();
            int bestCount = 1;

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    CheckSequence(CheckRow(matrix, i, j), ref bestCount, ref bestString, matrix, i, j);
                    CheckSequence(CheckCol(matrix, i, j), ref bestCount, ref bestString, matrix, i, j);
                    CheckSequence(CheckDiagonal(matrix, i, j), ref bestCount, ref bestString, matrix, i, j);
                }
            }

            if (bestString.Count == 1)
            {
                Console.WriteLine("The longest sequence of equal strings in the matrix is:", bestCount);
                for (int i = 0; i < bestCount - 1; i++)
                {
                    Console.Write(bestString[0] + ", ");
                }
                Console.WriteLine(bestString[0]);
            }
            else if (bestCount == 1)
            {
                Console.WriteLine("The matrix contains no sequences of equal strings longer than one element!");
            }
            else
            {
                Console.WriteLine("The matrix contains {0} sequences of equal strings:", bestString.Count);
                for (int i = 0; i < bestString.Count; i++)
                {
                    for (int j = 0; j < bestCount - 1; j++)
                    {
                        Console.Write(bestString[i] + ", ");
                    }
                    Console.WriteLine(bestString[i]);
                }
            }

        }

        private static void CheckSequence(int checker, ref int bestCount, ref List<string> bestString, string[,] matrix, int row, int col)
        {
            if (checker > bestCount)
            {
                bestCount = checker;
                bestString.Clear();
                bestString.Add(matrix[row, col]);
            }
            else if (checker == bestCount)
            {
                if (!bestString.Contains(matrix[row, col]))
                {
                    bestString.Add(matrix[row, col]);
                }
            }
        }

        static int CheckRow(string[,] matrix, int row, int col)
        {
            int count = 1;

            for (int i = col; i < matrix.GetLength(1) - 1; i++)
            {
                if (matrix[row, i] == matrix[row, i + 1])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }

        static int CheckCol(string[,] matrix, int row, int col)
        {
            int count = 1;

            for (int i = row; i < matrix.GetLength(0) - 1; i++)
            {
                if (matrix[i, col] == matrix[i + 1, col])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }

        static int CheckDiagonal(string[,] matrix, int row, int col)
        {
            int count = 1;

            for (int i = row, j = col; (i < matrix.GetLength(0) - 1) && (j < matrix.GetLength(1) - 1); i++, j++)
            {
                if (matrix[i, j] == matrix[i + 1, j + 1])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }
    }
}
