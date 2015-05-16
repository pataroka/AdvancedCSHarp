using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex rgx = new Regex(@"\b[a-zA-Z]\w{2,24}\b");
            MatchCollection matches = rgx.Matches(input);

            int largestSum = matches[0].Length + matches[1].Length;
            int indexOne = 0;
            int indexTwo = 1;

            for (int i = 1; i < matches.Count - 1; i++)
            {
                int temp = matches[i].Length + matches[i + 1].Length;
                if (temp > largestSum)
                {
                    largestSum = temp;
                    indexOne = i;
                    indexTwo = i + 1;
                }
            }

            Console.WriteLine(matches[indexOne]);
            Console.WriteLine(matches[indexTwo]);
        }
    }
}
