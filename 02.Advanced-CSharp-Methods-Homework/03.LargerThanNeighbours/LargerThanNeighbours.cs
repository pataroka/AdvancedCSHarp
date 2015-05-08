using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace _03.LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine().Trim();
            string pattern = "(\\D)+";
            string replacement = " ";
            Regex rgx = new Regex(pattern);
            string input = rgx.Replace(line, replacement);

            int[] numbers = Array.ConvertAll(input.Trim().Split(' '), int.Parse);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numbers, i));
            }

        }

        static string IsLargerThanNeighbours(int[] numbers, int i)
        {
            string result;

            if (numbers.Length > 1)
            {
                if (i == 0)
                {
                    result = (numbers[i] > numbers[i + 1]) ? "True" : "False";
                }
                else if (i == numbers.Length - 1)
                {
                    result = (numbers[i] > numbers[i - 1]) ? "True" : "False";
                }
                else
                {
                    result = ((numbers[i] > numbers[i + 1]) && (numbers[i] > numbers[i - 1])) ? "True" : "False";
                }
            }
            else
            {
                result = "No neighbouring numbers.";
            }
            return result;
        }
    }
}
