using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.ExtraxtEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex rgx = new Regex(@"(\w*[-._]*\w+)([-.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            Match match = rgx.Match(input);
            List<string> emails = new List<string>();

            while (match != Match.Empty)
            {
                string email = match.Value;
                if ((email[0] != '.')&&(email[0] != '-')&&(email[0] != '_'))
                {
                    emails.Add(email);
                }
                match = match.NextMatch();
            }

            foreach (string e in emails)
            {
                Console.WriteLine(e);
            }
        }
    }
}
