using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.OfficeStuff
{
    class OfficeStuff
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> companies = new Dictionary<string, Dictionary<string, int>>();

            char [] split = {'|','-', ' '};
            

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(split, StringSplitOptions.RemoveEmptyEntries);
                    
                if (!companies.ContainsKey(input[0]))
                {
                    companies.Add(input[0], new Dictionary<string, int>());
                    companies[input[0]].Add(input[2], int.Parse(input[1]));
                }
                else if (!companies[input[0]].ContainsKey(input[2]))
                {
                    companies[input[0]].Add(input[2], int.Parse(input[1]));
                }
                else
                {
                    companies[input[0]][input[2]] += int.Parse(input[1]);
                }
            }

            var query = from key in companies.Keys.ToList()
                orderby key ascending
                select key;

            foreach (var key in query)
            {
                Console.Write(key + ":");
                int i = 0;
                foreach (KeyValuePair<string, int> pair in companies[key])
                {
                    if (i == companies[key].Count - 1)
                    {
                        Console.WriteLine(" {0}-{1}", pair.Key, pair.Value);
                    }
                    else
                    {
                        Console.Write(" {0}-{1},", pair.Key, pair.Value);
                    }
                    i++;
                }
            }
        }
    }
}
