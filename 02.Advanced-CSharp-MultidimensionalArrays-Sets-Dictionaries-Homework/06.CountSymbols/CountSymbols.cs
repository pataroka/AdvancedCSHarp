using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            var chars = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (chars.ContainsKey(input[i]))
                {
                    chars[input[i]] += 1;
                }
                else
                {
                    chars.Add(input[i], 1);
                }
            }

            var list = chars.Keys.ToList();
            list.Sort();

            foreach (var key in list)
            {
                Console.WriteLine("{0}: {1} time/s", key, chars[key]);
            }
        }
    }
}
