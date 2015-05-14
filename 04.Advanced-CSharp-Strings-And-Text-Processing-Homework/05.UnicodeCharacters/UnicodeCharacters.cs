using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (char i in input)
            {
                Console.Write("\\u" + ((int)i).ToString("X4"));
            }
            Console.WriteLine();
        }
    }
}
