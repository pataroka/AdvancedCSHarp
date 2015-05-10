using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatrixShuffling
{
    class MatrixShuffling
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            
            string[,] matrix = new string[rows,cols];
            string[] input = Console.ReadLine().Trim().Split(' ');

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[0];
                    input = Console.ReadLine().Trim().Split(' ');
                }
            }

            do
            {
                if (input[0] == "swap")
                {
                    int x1 = int.Parse(input[1]);
                    int y1 = int.Parse(input[2]);
                    int x2 = int.Parse(input[3]);
                    int y2 = int.Parse(input[4]);

                    if ((x1 < rows) && (x2 < rows) && (y1 < cols) && (y2 < cols))
                    {
                        string temp = matrix[x1, y1];
                        matrix[x1, y1] = matrix[x2, y2];
                        matrix[x2, y2] = temp;
                        PrintMatrix(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }


                input = Console.ReadLine().Trim().Split(' ');
                
            } while (input[0] != "END");

        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,7}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
