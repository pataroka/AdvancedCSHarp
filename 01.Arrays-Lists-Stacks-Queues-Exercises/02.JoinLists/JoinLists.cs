using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.JoinLists
{
    class JoinLists
    {
        static void Main(string[] args)
        {
            string [] input = (Console.ReadLine() + " " + Console.ReadLine()).Split();

            List<int> result = new List<int>();
            
            for (int i = 0; i < input.Length; i++)
            {
                int number = int.Parse(input[i]);
                if (!result.Contains(number))
                {
                    result.Add(number);
                }
            }

            result.Sort();

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
