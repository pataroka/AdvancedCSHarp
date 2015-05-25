using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CouplesFrequency
{
    class CouplesFrequency
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            Dictionary<string, int> sequences = new Dictionary<string, int>();

            for (int i = 0; i < input.Length - 1; i++)
            {
                string temp = input[i] + " " + input[i + 1];
                if (!sequences.ContainsKey(temp))
                {
                    sequences.Add(temp, 1);
                }
                else
                {
                    sequences[temp]++;
                }
            }

            foreach (KeyValuePair<string, int> pair in sequences)
            {
                double frequency = Math.Round((double) (pair.Value*100)/(input.Length - 1), 2);
                Console.WriteLine("{0} -> {1:F2}%", pair.Key, frequency);
            }
        }
    }
}
