using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace _07.LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Trim().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            decimal total = 0;

            foreach (string str in input)
            {
                decimal number = Convert.ToDecimal(str.Substring(1, str.Length - 2));

                if (Char.IsLower(str.First()))
                {
                    number *= (decimal)str.First() - 96;
                }
                else
                {
                    number /= (decimal)str.First() - 64;
                }

                if (Char.IsLower(str.Last()))
                {
                    number += (decimal)str.Last() - 96;
                }
                else
                {
                    number -= (decimal)str.Last() - 64;
                }

                total += number;
            }
            Console.WriteLine("{0:F2}", total);
        }
    }
}
