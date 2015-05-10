using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FillTheMatrixB
{
    class FillTheMatrixB
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int count = 1;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (i%2 == 0)
                {
                    FillDown(matrix, ref count, i);
                }
                else
                {
                    FillUp(matrix, ref count, i);
                }
            }

            PrintMatrix(matrix);
        }

        static void FillDown(int[,] matrix, ref int count, int i)
        {
            for (int j = 0; j < matrix.GetLength(0); j++, count++)
            {
                matrix[j, i] = count;
            }
        }

        static void FillUp(int[,] matrix, ref int count, int i)
        {
            for (int j = matrix.GetLength(0) - 1; j >= 0; j--, count++)
            {
                matrix[j, i] = count;
            }
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
    }
}
