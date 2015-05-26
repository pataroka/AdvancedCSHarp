using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _16.LittleJohn
{
    class LittleJohn
    {
        static void Main(string[] args)
        {
            const string large = ">>>----->>";
            const string medium = ">>----->";
            const string small = ">----->";
            string input;
            Dictionary<string, int> arrows = new Dictionary<string, int>()
            {
                {large, 0},
                {medium, 0},
                {small, 0},
            };

            Regex rgx = new Regex(@"(>>>----->>)|(>>----->)|(>----->)");

            for (int i = 0; i < 4; i++)
            {
                input = " " + Console.ReadLine() + " ";
                Match match = rgx.Match(input);

                while (match != Match.Empty)
                {
                    switch (match.Value)
                    {
                        case large:
                            arrows[large]++;
                            break;
                        case medium:
                            arrows[medium]++;
                            break;
                        case small:
                            arrows[small]++;
                            break;
                    }

                    match = match.NextMatch();
                }
            }

            uint result = uint.Parse(String.Format("{0}{1}{2}", arrows[small], arrows[medium], arrows[large]));
            string binary = Convert.ToString(result, 2);
            char[] arr = binary.ToCharArray();
            Array.Reverse(arr);
            binary += new string(arr);
            result = Convert.ToUInt32(binary, 2);

            Console.WriteLine(result);

        }
    }
}
