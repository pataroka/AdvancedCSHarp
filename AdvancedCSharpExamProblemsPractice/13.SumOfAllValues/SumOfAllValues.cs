using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace _13.SumOfAllValues
{
    class SumOfAllValues
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            string keyString = Console.ReadLine();
            string textString = Console.ReadLine();
            Regex rgx = new Regex(@"^([A-Za-z_]+)(?=\d).*(?<=\d)([A-Za-z_]+)$");
            MatchCollection matches = rgx.Matches(keyString);
            if (matches.Count == 0)
            {
                Console.WriteLine("<p>A key is missing</p>");
            }
            else
            {
                string start = matches[0].Groups[1].Value;
                string end = matches[0].Groups[2].Value;
                rgx = new Regex(start + "(.*?)" + end);
                Match match = rgx.Match(textString);
                decimal result = Decimal.Zero;

                while (match != Match.Empty)
                {
                    decimal number;
                    bool check = decimal.TryParse(match.Groups[1].Value, out number);
                    if (check)
                    {
                        result += number;
                    }
                    match = match.NextMatch();
                }

                if (result == 0)
                {
                    Console.WriteLine("<p>The total value is: <em>nothing</em></p>");
                }
                else
                {
                    Console.WriteLine("<p>The total value is: <em>{0}</em></p>", result);
                }
            }
            
        }
    }
}
