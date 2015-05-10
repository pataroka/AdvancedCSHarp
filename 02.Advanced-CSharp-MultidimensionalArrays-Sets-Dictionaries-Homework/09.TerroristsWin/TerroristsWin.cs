using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09.TerroristsWin
{
    class TerroristsWin
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"(\|.*?\|)");
            Match match = regex.Match(input);

            do
            {
                int bombPower = 0;

                for (int i = 1; i < match.Length - 1; i++)
                {
                    bombPower += match.Value[i];
                }

                bombPower %= 10;
                Regex explosion = new Regex(@".{0," + bombPower + @"}?\|(.*?)\|.{0," + bombPower + "}");
                Match explode = explosion.Match(input);

                string bomb = "";
                for (int i = 0; i < explode.Length; i++)
                {
                    bomb += '.';
                }

                input = input.Replace(explode.Value, bomb);
                

                match = match.NextMatch();


            } while (match != Match.Empty);

            Console.WriteLine(input);
        }
    }
}
