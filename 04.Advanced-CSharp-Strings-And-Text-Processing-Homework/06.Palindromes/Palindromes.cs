using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedSet<string> result = new SortedSet<string>();
            Regex rgx = new Regex(@"[A-Za-z]\w*");
            Match match = rgx.Match(input);

            while (match != Match.Empty)
            {
                string reverse = StringReverse(match.Value);
                if (reverse == match.Value)
                {
                    result.Add(match.Value);
                }

                match = match.NextMatch();
            }

            Console.WriteLine(string.Join(", ", result));
        }

        public static string StringReverse(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
