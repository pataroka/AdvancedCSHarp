using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.FullDirectoryTraversal
{
    class FullDirectoryTraversal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter directory:");
            string inputDir = Console.ReadLine() + "\\";
            string outputDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "report.txt");
            Regex rgx = new Regex(@"([\w\d\W]*)\\(?<=\\)([\w\d\W]*)(?=\.)(\.\w+)");
            var fileTypeCount = new Dictionary<string, int>();
            var fileTypeEntries = new Dictionary<string, Dictionary<string, double>>();

            string[] files = Directory.GetFiles(inputDir, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                FileInfo f = new FileInfo(file);
                double fileSize = Math.Round(f.Length / 1024.0, 3);
                Match match = rgx.Match(file);
                string fileType = match.Groups[3].Value;
                string fileName = file;

                if (!fileTypeCount.ContainsKey(fileType))
                {
                    fileTypeCount.Add(fileType, 1);
                    fileTypeEntries.Add(fileType, new Dictionary<string, double>());
                    fileTypeEntries[fileType].Add(fileName, fileSize);
                }
                else
                {
                    fileTypeCount[fileType]++;
                    fileTypeEntries[fileType].Add(fileName, fileSize);
                }
            }

            using (StreamWriter writer = new StreamWriter(outputDir, false, Encoding.UTF8))
            {
                foreach (KeyValuePair<string, int> pairCount in SortDictByValueDescending(fileTypeCount))
                {
                    writer.WriteLine("{0} found {1} times in current directory and its subdirectories.", pairCount.Key, pairCount.Value);
                    foreach (KeyValuePair<string, double> pairSize in SortDictByValueAscending(fileTypeEntries[pairCount.Key]))
                    {
                        writer.WriteLine("--{0} - {1:##.###}kb", pairSize.Key, pairSize.Value);
                    }
                }
            }

            System.Diagnostics.Process.Start(outputDir);
        }

        private static IOrderedEnumerable<KeyValuePair<string, int>> SortDictByValueDescending(Dictionary<string, int> dictToSort)
        {
            var sorted = from pair in dictToSort orderby pair.Value descending, pair.Key ascending select pair;
            return sorted;
        }

        private static IOrderedEnumerable<KeyValuePair<string, double>> SortDictByValueAscending(Dictionary<string, double> dictToSort)
        {
            var sorted = from pair in dictToSort orderby pair.Value ascending, pair.Key ascending select pair;
            return sorted;
        }
    }
}
