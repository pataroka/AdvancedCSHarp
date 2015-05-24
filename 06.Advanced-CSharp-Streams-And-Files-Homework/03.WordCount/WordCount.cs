using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            StreamReader words = StreamReader.Null;
            StreamReader text = StreamReader.Null;
            StreamWriter result = StreamWriter.Null;
            Regex word = new Regex(@"(\w*[^_\W])");
            var checkedWords = new SortedDictionary<string, int>();

            try
            {
                words = new StreamReader("../../words.txt");
                text = new StreamReader("../../text.txt");
                result = new StreamWriter("../../result.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read/created:");
                Console.WriteLine(e.Message);
            }

            using (words)
            using (text)
            using (result)
            {
                string wordsTxt = words.ReadToEnd();
                Match match = word.Match(wordsTxt);

                while (match != Match.Empty)
                {
                    if (!checkedWords.ContainsKey(match.Value.ToLower()))
                    {
                        checkedWords.Add(match.Value.ToLower(), 0);
                    }
                    match = match.NextMatch();
                }

                string textTxt = text.ReadToEnd();
                match = word.Match(textTxt);

                while (match != Match.Empty)
                {
                    if (checkedWords.ContainsKey(match.Value.ToLower()))
                    {
                        checkedWords[match.Value.ToLower()]++;
                    }
                    match = match.NextMatch();
                }

                foreach (KeyValuePair<string, int> pair in checkedWords)
                {
                    result.WriteLine("{0} - {1}", pair.Key, pair.Value);
                }
            }
            Console.WriteLine("Success!");
        }
    }
}
