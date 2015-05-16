using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.ExtractHyperlinks
{
    class ExtractHyperlinks
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder();
            string line = Console.ReadLine();

            while (line != "END")
            {
                input.Append(line);
                line = Console.ReadLine();
            }

            string text = input.ToString();

            Regex rgx = new Regex(@"<a\s+(?:[^>]+\s+)?href\s*=\s*(?:'([^']*)'|""([^""]*)""|([^\s>]+))[^>]*>");
            Match match = rgx.Match(text);

            while (match != Match.Empty)
            {
                for (int i = 1; i < match.Groups.Count; i++)
                {
                    if (match.Groups[i].Value != String.Empty)
                    {
                        Console.WriteLine(match.Groups[i].Value);
                    }
                }
                
                match = match.NextMatch();
            }
        }
    }
}
