using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _14.TextGravity
{
    class TextGravity
    {
        static void Main(string[] args)
        {
            int lineLength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int cols = lineLength;
            int rows = input.Length%lineLength == 0 ? input.Length/lineLength : input.Length/lineLength + 1;

            char[,] matrix = new char[rows, cols];

            FillMatrix(rows, cols, input, matrix);
            DropChars(matrix);
            StringBuilder sb = new StringBuilder();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row == 0)
                {
                    sb.Append("<table>");
                }
                sb.Append("<tr>");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sb.Append("<td>");
                    sb.Append(SecurityElement.Escape(matrix[row, col].ToString()));
                    sb.Append("</td>");
                }
                sb.Append(row == matrix.GetLength(0) - 1 ? "</tr></table>" : "</tr>");
            }

            Console.WriteLine(sb.ToString());
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
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (index >= input.Length)
                    {
                        matrix[i, j] = ' ';
                    }
                    else
                    {
                        matrix[i, j] = input[index];
                    }
                    index++;
                }
            }
        }
    }
}
