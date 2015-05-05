using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int[] numbers = Array.ConvertAll(input, int.Parse);
            bool swap = false;

            do
            {
                swap = false;
                Swap(numbers, ref swap);
            } while (swap);

            Console.WriteLine(string.Join(", ", numbers));

        }

        private static void Swap(int[] numbers, ref bool swap)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[i + 1];
                    numbers[i + 1] = temp;
                    swap = true;
                }
            }
        }
    }
}
