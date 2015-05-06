using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int minValue = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < minValue)
                    {
                        minValue = numbers[j];
                        index = j;
                    }
                }

                if (minValue < numbers[i])
                {
                    int temp = numbers[i];
                    numbers[i] = minValue;
                    numbers[index] = temp;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
