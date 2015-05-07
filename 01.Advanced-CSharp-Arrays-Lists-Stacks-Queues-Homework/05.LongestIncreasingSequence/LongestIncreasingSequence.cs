using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LongestIncreasingSequence
{
    class LongestIncreasingSequence
    {
        static void Main(string[] args)
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            List<int> temp = new List<int>();
            List<int> longest = new List<int>();

            for (int i = 0, j = 1; i < numbers.Length; i++, j++)
            {
                temp.Add(numbers[i]);
                
                if ((j < numbers.Length) && (numbers[i] <= numbers[j]))
                {
                    continue;
                }
                else
                {
                    if (temp.Count > longest.Count)
                    {
                        longest.Clear();
                        longest.AddRange(temp);
                        Console.WriteLine(string.Join(" ", temp));
                        temp.Clear();
                    }
                    else
                    {
                        Console.WriteLine(string.Join(" ", temp));
                        temp.Clear();
                    }
                }
            }

            Console.WriteLine("Longest: " + string.Join(" ", longest));
        }
    }
}
