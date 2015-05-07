using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.LegoBlocks
{
    class LegoBlocks
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            string[][] arr1 = new string[rows][];
            string[][] arr2 = new string[rows][];
            int totalCells = 0;

            for (int i = 0; i < rows; i++)
            {
                string input = Console.ReadLine().Trim();
                string pattern = "\\s+";
                string replacement = " ";
                Regex rgx = new Regex(pattern);
                string result = rgx.Replace(input, replacement);

                string[] line = result.Split(' ');
                arr1[i] = line;
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    totalCells++;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                string input = Console.ReadLine().Trim();
                string pattern = "\\s+";
                string replacement = " ";
                Regex rgx = new Regex(pattern);
                string result = rgx.Replace(input, replacement);

                string[] line = result.Split(' ');
                arr2[i] = line;
                for (int j = 0; j < arr2[i].Length; j++)
                {
                    totalCells++;
                }
            }

            bool fits = false;
            int match = arr1[0].Length + arr2[0].Length;

            for (int i = 1; i < rows; i++)
            {
                if (match == arr1[i].Length + arr2[i].Length)
                {
                    fits = true;
                }
                else
                {
                    fits = false;
                    break;
                }
            }

            if (fits)
            {
                string[,] matrix = new string[rows, match];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < arr1[i].Length; j++)
                    {
                        matrix[i, j] = arr1[i][j];
                    }

                    int addOn = arr1[i].Length;

                    for (int k = arr2[i].Length - 1; k >= 0; k--)
                    {
                        matrix[i, addOn] = arr2[i][k];
                        addOn++;
                    }
                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    Console.Write("[");
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j != matrix.GetLength(1) - 1)
                        {
                            Console.Write(matrix[i, j] + ", ");
                        }
                        else
                        {
                            Console.Write(matrix[i, j] + "]");
                            Console.WriteLine();
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("The total number of cells is: " + totalCells);
            }
        }
    }
}
