using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09.SemanticHTML
{
    class SemanticHTML
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex rgxOpen = new Regex("(\\s*)<(div).*((id|class)\\s*=\\s*\"(.*?)\").*(?=>)");
            Regex rgxClose = new Regex("(\\s*)<\\/div>\\s.*?(\\w+)\\s*-->");
            List<string> result = new List<string>();
            string semantic;
            Match match;

            while (input != "END")
            {
                if (input.Contains("<div"))
                {
                    match = rgxOpen.Match(input);

                    semantic = match.Value;
                    semantic = semantic.Replace(match.Groups[2].Value, match.Groups[5].Value);
                    semantic = semantic.Replace(match.Groups[3].Value, " ");
                    semantic = Regex.Replace(semantic.Trim(), "\\s+", " ");
                    semantic = match.Groups[1].Value + semantic + ">";
                    result.Add(semantic);
                }
                else if (input.Contains("</div"))
                {
                    match = rgxClose.Match(input);
                    semantic = match.Groups[1].Value + "</" + match.Groups[2].Value + ">";
                    result.Add(semantic);
                }
                else
                {
                    result.Add(input);
                }
                input = Console.ReadLine();
            }
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}
