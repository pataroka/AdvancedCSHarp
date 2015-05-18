using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string match = Console.ReadLine().ToLower();
            int count = 0;

            for (int i = 0; i <= input.Length - match.Length; i++)
            {
                if (match == input.Substring(i, match.Length))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
