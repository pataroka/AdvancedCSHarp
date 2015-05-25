using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PaintBall
{
    class PaintBall
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 1023;
            }

            string[] shot = Console.ReadLine().Split(' ');
            bool black = true;

            do
            {
                int radius = int.Parse(shot[2]);
                int row = int.Parse(shot[0]);
                int col = int.Parse(shot[1]);
                int startRow = (row - radius <= 0) ? 0 : row - radius;
                int endRow = (row + radius >= 9) ? 9 : row + radius;
                int startCol = (col - radius <= 0) ? 0 : col - radius;
                int endCol = (col + radius >= 9) ? 9 : col + radius;

                for (int i = startRow; i <= endRow; i++)
                {
                    for (int j = startCol; j <= endCol; j++)
                    {
                        if (black)
                        {
                            numbers[i] &= ~(1 << j);
                        }
                        else
                        {
                            numbers[i] |= (1 << j);
                        }
                    }
                }

                black = !black;
                shot = Console.ReadLine().Split(' ');

            } while (shot[0] != "End");

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}
