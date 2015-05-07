using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SubsetSums
{
    class SubsetSums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var numbers = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));

            bool found = false;

            int numOfSubsets = 1 << numbers.Count;

            for (int i = 0; i < numOfSubsets; i++)
            {
                List<int> subset = new List<int>();
                int pos = numbers.Count - 1;
                int bitmask = i;

                while (bitmask > 0)
                {
                    if ((bitmask & 1) == 1)
                    {
                        subset.Add(numbers.ElementAt<int>(pos));
                    }
                    bitmask >>= 1;
                    pos--;
                }
                if ((subset.Sum() == n) && (subset.Count != 0))
                {
                    found = true;
                    Console.WriteLine(string.Join(" + ", subset) + " = {0}", n);
                }
            }
            if (!found)
            {
                Console.WriteLine("No matching subsets.");
            }
        }
    }
}
