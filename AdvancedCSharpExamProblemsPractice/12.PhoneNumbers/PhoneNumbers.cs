using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _12.PhoneNumbers
{
    class PhoneNumbers
    {
        static void Main(string[] args)
        {
            Regex rgx = new Regex(@"([A-Z][A-Za-z]*)(?:[^A-Za-z+\d]*)(?=\+[.\-()\/\s\d]*\d{2}|[\d]{2})([+\d.()\/\-\s]+)");
            List<string> result = new List<string>();
            StringBuilder sb = new StringBuilder();
            string input = Console.ReadLine();

            while (input != "END")
            {
                sb.Append(input);
                input = Console.ReadLine();
            }

            
            MatchCollection matches = rgx.Matches(sb.ToString());
            sb.Clear();
            if (matches.Count != 0)
            {
                for (int i = 0; i < matches.Count; i++)
                {
                    if (i == 0)
                    {
                        sb.Append("<ol>");
                    }
                    sb.Append(String.Format("<li><b>{0}:</b> {1}</li>", matches[i].Groups[1].Value, Regex.Replace(matches[i].Groups[2].Value, @"[^\d+]", "")));
                    if (i == matches.Count - 1)
                    {
                        sb.Append("</ol>");
                    }
                }
                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine("<p>No matches!</p>");
            }
            
        }
    }
}
