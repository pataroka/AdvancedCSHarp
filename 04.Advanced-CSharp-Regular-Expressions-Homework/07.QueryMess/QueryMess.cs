using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.QueryMess
{
    class QueryMess
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex rgx = new Regex(@"([^=&]+)=([^&]*)");
            string key = "";
            string value = "";

            while (input != "END")
            {
                input = Regex.Replace(input, @".+?(?=\?)(\?)+", "+");
                input = input.Replace("%20", " ");
                input = input.Replace('+', ' ');
                Match match = rgx.Match(input);
                var query = new Dictionary<string, List<string>>();

                while (match != Match.Empty)
                {
                    string[] pair = match.Value.Split('=');
                    key = Regex.Replace(pair[0].Trim(), @"\s+", " ");
                    value = Regex.Replace(pair[1].Trim(), @"\s+", " ");
                    if (query.ContainsKey(key))
                    {
                        query[key].Add(value);
                    }
                    else
                    {
                        query.Add(key, new List<string>());
                        query[key].Add(value);
                    }
                    match = match.NextMatch();
                }
                foreach (string s in query.Keys)
                {
                    Console.Write(s + "=[" + string.Join(", ", query[s]) + "]");
                }
                Console.WriteLine();
                input = Console.ReadLine();
            }
        }
    }
}
