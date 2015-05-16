using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.UseYourChainsBuddy
{
    class UseYourChainsBuddy
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex rgx = new Regex(@"<p>(.*?)<\/p>");
            Match match = rgx.Match(input);
            StringBuilder sb = new StringBuilder();

            while (match != Match.Empty)
            {
                string text = Regex.Replace(match.Groups[1].Value, @"[^a-z0-9]+", " ");
                text = Regex.Replace(text, @"\s+", " ");
                

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] >= 97 && text[i] <= 109)
                    {
                        sb.Append((char)(text[i] + 13));
                    }
                    else if (text[i] >= 110 && text[i] <= 122)
                    {
                        sb.Append((char)(text[i] - 13));
                    }
                    else
                    {
                        sb.Append(text[i]);
                    }
                }
                match = match.NextMatch();
            }

            Console.WriteLine(sb.ToString());

        }
    }
}
