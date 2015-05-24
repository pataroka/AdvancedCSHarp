using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.SlicingFile
{
    class SlicingFile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input path of file:");
            string inputPath = Console.ReadLine();
            Console.WriteLine("Enter number of parts to be split to:");
            int parts = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter destination directory:");
            string destination = Console.ReadLine();

            Slice(inputPath, destination, parts);

            string[] files = Directory.GetFiles(destination);
            List<string> filesList = files.Where(f => f.Contains("Part")).ToList();

            Assemble(filesList, destination);
        }

        private static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            using (var source = new FileStream(sourceFile, FileMode.Open))
            {
                long partSize = source.Length / parts;
                long remainingSize = source.Length;
                Regex rgx = new Regex(@"([\w\d\W]*)\\(?<=\\)([\w\d\W]*)(?=\.)\.(?<=\.)(\w+)");
                Match match = rgx.Match(sourceFile);

                for (int i = 0; i < parts; i++)
                {
                    FileStream partFileStream;
                    string outputPath = destinationDirectory + "\\" + String.Format(@"Part-{0}", i) + "." + match.Groups[3];

                    using (partFileStream = new FileStream(outputPath, FileMode.Create))
                    {
                        long currentSize = 0;
                        byte[] buffer = new byte[4096];
                        while (currentSize < partSize)
                        {
                            int readBytes = source.Read(buffer, 0, buffer.Length);
                            if (readBytes == 0)
                            {
                                break;
                            }

                            partFileStream.Write(buffer, 0, readBytes);
                            currentSize += readBytes;
                        }
                    }

                    remainingSize -= partSize;
                    partSize = remainingSize < partSize ? remainingSize : partSize;
                }
            }
        }

        private static void Assemble(List<string> files, string destinationDirectory)
        {
            Regex rgx = new Regex(@"([\w\d\W]*)\\(?<=\\)([\w\d\W]*)(?=\.)\.(?<=\.)(\w+)");
            Match match = rgx.Match(files[0]);
            string outputPath = destinationDirectory + "assembled-result" + "." + match.Groups[3];
            var outputFile = new FileStream(outputPath, FileMode.Create);
            outputFile.Close();

            using (outputFile = new FileStream(outputPath, FileMode.Append))
            {
                foreach (var file in files)
                {
                    using (var sourceFile = new FileStream(file, FileMode.Open))
                    {
                        Byte[] buffer = new byte[sourceFile.Length];
                        int readBytes = sourceFile.Read(buffer, 0, buffer.Length);
                        outputFile.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
