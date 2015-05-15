using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            for (int i = 97; i < 123; i++)
            {
                char ch = (char)i;
                string r = ch.ToString() + "+";
                Regex rgx = new Regex(@r);
                Match match = rgx.Match(input);

                while (match != Match.Empty)
                {
                    input = input.Replace(match.Value, ch.ToString());
                    match = match.NextMatch();
                }
            }
            Console.WriteLine(input);
        }
    }
}
