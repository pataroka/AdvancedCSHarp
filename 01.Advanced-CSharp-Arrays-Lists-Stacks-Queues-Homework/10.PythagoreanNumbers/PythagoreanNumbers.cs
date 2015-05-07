using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PythagoreanNumbers
{
    class PythagoreanNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            bool found = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        if (numbers[i] <= numbers[j])
                        { 
                            if ((numbers[i]*numbers[i] + numbers[j]*numbers[j]) == numbers[k]*numbers[k])
                            {
                                found = true;
                                Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", numbers[i], numbers[j], numbers[k]);
                            }
                        }
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}
