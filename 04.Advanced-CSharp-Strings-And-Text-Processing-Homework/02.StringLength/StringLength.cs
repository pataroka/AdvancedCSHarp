using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            if (input.Length < 20)
            {
                for (int i = input.Length; i < 20; i++)
                {
                    input.Append('*');
                }
            }
            else if (input.Length > 20)
            {
                input.Remove(20, input.Length - 20);
            }
            Console.WriteLine(input.ToString());
        }
    }
}
