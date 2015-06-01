using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P4
{
    class Country
    {
        public string Name;
        public List<string> Participants;
        public int Wins;

        public Country()
        {
            Name = String.Empty;
            Participants = new List<string>();
            Wins = 0;
        }

    }
    
    class P4
    {
        static void Main(string[] args)
        {
            var countries = new Dictionary<string, Country>();

            string input = Regex.Replace(Console.ReadLine(), @"\s+", " ");

            while (input != "report")
            {
                string[] data = input.Split('|');
                string name = data[0].Trim();
                string country = data[1].Trim();

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Country());
                    countries[country].Name = country;
                    countries[country].Participants.Add(name);
                    countries[country].Wins = 1;
                }
                else
                {
                    if (!countries[country].Participants.Contains(name))
                    {
                        countries[country].Participants.Add(name);
                        countries[country].Wins++;
                    }
                    else
                    {
                        countries[country].Wins++;
                    }
                    
                }

                input = Regex.Replace(Console.ReadLine(), @"\s+", " ");
            }

            var query = from c in countries
                orderby c.Value.Wins descending
                select c;

            foreach (var c in query)
            {
                Console.WriteLine("{0} ({1} participants): {2} wins", c.Key,c.Value.Participants.Count, c.Value.Wins);
            }
            
                
        }
    }
}
