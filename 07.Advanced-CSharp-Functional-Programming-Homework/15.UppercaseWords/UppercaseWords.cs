using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _15.UppercaseWords
{
    class UppercaseWords
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex rgx = new Regex(@"(?<=[^A-Za-z])([A-Z][A-Z]*)(?=[^A-Za-z])|(?<=[^A-Za-z])([A-Z][A-Z]*)\b|\b([A-Z][A-Z]*)(?=[^A-Za-z])");

            while (input != "END")
            {
                MatchCollection matches = rgx.Matches(input);
                var hashset = new HashSet<string>();
                for (int i = 0; i < matches.Count; i++)
                {
                    hashset.Add(matches[i].Value);
                }

                string[] strings = Regex.Split(input, @"(?<=[^A-Za-z])([A-Z][A-Z]*)(?=[^A-Za-z])|(?<=[^A-Za-z])([A-Z][A-Z]*)\b|\b([A-Z][A-Z]*)(?=[^A-Za-z])");
                StringBuilder result = new StringBuilder();

                for (int i = 0; i < strings.Length; i++)
                {
                    if (hashset.Contains(strings[i]))
                    {
                        char[] arr = strings[i].ToCharArray();
                        Array.Reverse(arr);
                        string reversed = new string(arr);
                        if (strings[i] == reversed)
                        {
                            StringBuilder sb = new StringBuilder();
                            foreach (char c in reversed)
                            {
                                sb.Append(c, 2);
                            }
                            reversed = sb.ToString();
                        }
                        strings[i] = reversed;
                    }
                    result.Append(strings[i]);
                }


                Console.WriteLine(SecurityElement.Escape(result.ToString()));

                input = Console.ReadLine();
            }
        }
    }
}
