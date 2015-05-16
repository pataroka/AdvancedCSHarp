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
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if ((input[i] != ' ') && (input[i] != ',') && (input[i] != '.')  && (input[i] != '!')  && (input[i] != '?'))
                {
                    sb.Append(input[i]);
                }
                else
                {
                    string reverse = StringReverse(sb.ToString());
                    if ((sb.ToString() == reverse) && (reverse != String.Empty))
                    {
                        result.Add(reverse);
                    }
                    sb.Clear();
                }
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
