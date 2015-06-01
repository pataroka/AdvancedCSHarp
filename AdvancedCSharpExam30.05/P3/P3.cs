using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P3
{
    class P3
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string input = Console.ReadLine();
            List<string> list = new List<string>();

            while (input != "burp")
            {
                sb.Append(input);
                input = Console.ReadLine();
            }
            string result = sb.ToString();
            Regex.Replace(result, @"\s+", " ");

            var matches = Regex.Matches(result, @"\$([^$%&']+)\$|\%([^$%&']+)\%|\&([^$%&']+)\&|\'([^$%&']+)\'");

            for (int i = 0; i < matches.Count; i++)
            {
                char transformer = matches[i].Value[0];
                int weight = 0;

                switch (transformer)
                {
                    case '$':
                        weight = 1;
                        break;
                    case '%':
                        weight = 2;
                        break;
                    case '&':
                        weight = 3;
                        break;
                    case '\'':
                        weight = 4;
                        break;
                }

                for (int j = 1; j < matches[i].Groups.Count; j++)
                {
                    if (matches[i].Groups[j].Value != String.Empty)
                    {
                        result = matches[i].Groups[j].Value;
                    }

                }


                sb.Clear();


                for (int j = 0; j < result.Length; j++)
                {
                    char current = result[j];
                    if (j % 2 == 0)
                    {
                        current = (char)(current + weight);
                        sb.Append(current);
                    }
                    else
                    {
                        current = (char)(current - weight);
                        sb.Append(current);
                    }
                }

                list.Add(sb.ToString());
                
            }
           Console.WriteLine(string.Join(" ", list));
        }
    }
}
