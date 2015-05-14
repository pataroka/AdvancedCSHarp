using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            string[] banList = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            for (int i = 0; i < banList.Length; i++)
            {
                text = text.Replace(banList[i], CreateAsterisk(banList[i]));
            }
            Console.WriteLine(text);

        }

        static string CreateAsterisk(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                result.Append('*');
            }
            return result.ToString();
        }

    }
}
