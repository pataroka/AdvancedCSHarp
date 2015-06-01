using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MatrixShuffle
{
    class MatrixShuffle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            char[,] matrix = new char[n,n];
            int steps = n%2 == 0 ? n*2 : n*2 - 1;

            int pos = 0;
            int count = n;
            int value = -n;
            int sum = -1;

            do
            {
                value = -1 * value / n;
                for (int i = 0; i < count; i++)
                {
                    sum += value;
                    matrix[sum / n, sum % n] = text[pos];
                    pos++;
                }
                value *= n;
                count--;
                for (int i = 0; i < count; i++)
                {
                    sum += value;
                    matrix[sum / n, sum % n] = text[pos];
                    pos++;
                }
            } while (count > 0);
        }
    }
}
