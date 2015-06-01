using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace _10.ClearingCommands
{
    class ClearingCommands
    {
        static void Main(string[] args)
        {
            List<char[]> matrix = new List<char[]>();
            string input = Console.ReadLine();
            int cols = input.Length;
            string commands = "<>^v";

            while (input != "END")
            {
                matrix.Add(input.ToCharArray());
                input = Console.ReadLine();
            }
            int rows = matrix.Count;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    switch (matrix[row][col])
                    {
                        case '<':
                            for (int i = col; i > 0; i--)
                            {
                                if (!commands.Contains(matrix[row][i - 1]))
                                {
                                    matrix[row][i - 1] = ' ';
                                }
                                else
                                {
                                    break;
                                }
                            }
                            break;
                        case '>':
                            for (int i = col; i < cols - 1; i++)
                            {
                                if (!commands.Contains(matrix[row][i + 1]))
                                {
                                    matrix[row][i + 1] = ' ';
                                }
                                else
                                {
                                    break;
                                }
                            }
                            break;
                        case '^':
                            for (int i = row; i > 0; i--)
                            {
                                if (!commands.Contains(matrix[i - 1][col]))
                                {
                                    matrix[i - 1][col] = ' ';
                                }
                                else
                                {
                                    break;
                                }
                            }
                            break;
                        case 'v':
                            for (int i = row; i < rows - 1; i++)
                            {
                                if (!commands.Contains(matrix[i + 1][col]))
                                {
                                    matrix[i + 1][col] = ' ';
                                }
                                else
                                {
                                    break;
                                }
                            }
                            break;
                    }
                }
            }

            foreach (var arr in matrix)
            {
                Console.Write("<p>");
                Console.Write(SecurityElement.Escape(new string(arr)));
                Console.WriteLine("</p>");
            }
        }
    }
}
