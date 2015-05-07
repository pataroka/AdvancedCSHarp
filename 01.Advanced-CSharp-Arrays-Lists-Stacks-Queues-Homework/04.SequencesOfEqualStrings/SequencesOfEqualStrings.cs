using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SequencesOfEqualStrings
{
    class SequencesOfEqualStrings
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            List<string> temp = new List<string>();

            for (int i = 0, j = 1; i < input.Length; i++, j++)
            {
                temp.Add(input[i]);

                if ((j < input.Length) && (input[i].Equals(input[j])))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(string.Join(" ", temp));
                    temp.Clear();
                }
            }
        }
    }
}
