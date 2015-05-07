using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.StuckNumbers
{
    class StuckNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool exist = false;

            if (n >= 4)
            {
                string[] numbers = Console.ReadLine().Trim().Split(' ');

                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (j == i)
                        {
                            continue;
                        }
                        for (int k = 0; k < numbers.Length; k++)
                        {
                            if ((k == i) || (k == j))
                            {
                                continue;
                            }
                            for (int l = 0; l < numbers.Length; l++)
                            {
                                if ((l == i) || (l == j) || (l == k))
                                {
                                    continue;
                                }
                                string left = numbers[i] + numbers[j];
                                string right = numbers[k] + numbers[l];

                                if (left.Equals(right))
                                {
                                    exist = true;
                                    Console.WriteLine(numbers[i] + "|" + numbers[j] + "==" + numbers[k] + "|" + numbers[l]);
                                }
                            }
                        }
                    }
                }
                if (!exist)
                {
                    Console.WriteLine("No");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
