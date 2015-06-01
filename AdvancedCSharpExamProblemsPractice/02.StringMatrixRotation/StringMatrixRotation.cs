using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.StringMatrixRotation
{
    class StringMatrixRotation
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"([0-9])\d*");
            Match match = regex.Match(input);
            int command = int.Parse(match.Value);
            command /= 90;
            command %= 4;
            input = Console.ReadLine();
            int matrixSize = 0;
            var strings = new List<string>();

            while (input != "END")
            {

                strings.Add(input);
                matrixSize = (matrixSize < input.Length) ? input.Length : matrixSize;
                input = Console.ReadLine();
            }

            char[,] matrix = new char[strings.Count, matrixSize];

            for (int i = 0; i < strings.Count; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (j < strings[i].Length)
                    {
                        matrix[i, j] = strings[i][j];
                    }
                    else
                    {
                        matrix[i, j] = ' ';
                    }
                }
            }

            switch (command)
            {
                case 1:
                    for (int i = 0; i < matrixSize; i++)
                    {
                        for (int j = matrix.GetLength(0) - 1; j >= 0; j--)
                        {
                            Console.Write(matrix[j, i]);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
                    {
                        for (int j = matrixSize - 1; j >= 0; j--)
                        {
                            Console.Write(matrix[i, j]);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    for (int i = matrixSize - 1; i >= 0; i--)
                    {
                        for (int j = 0; j < matrix.GetLength(0); j++)
                        {
                            Console.Write(matrix[j, i]);
                        }
                        Console.WriteLine();
                    }
                    break;
                default:
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrixSize; j++)
                        {
                            Console.Write(matrix[i, j]);
                        }
                        Console.WriteLine();
                    }
                    break;
            }
        }
    }
}