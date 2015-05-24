using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.ZippingSlicedFiles
{
    class ZippingSlicedFiles
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

                for (int i = 0; i < parts; i++)
                {
                    FileStream partFileStream;
                    string outputPath = destinationDirectory + "\\" + String.Format(@"Part-{0}", i) + ".gz";

                    using (partFileStream = new FileStream(outputPath, FileMode.Create))
                    {
                        using (var zipStream = new GZipStream(partFileStream, CompressionMode.Compress, false))
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

                                zipStream.Write(buffer, 0, readBytes);
                                currentSize += readBytes;
                            }
                        }
                    }

                    remainingSize -= partSize;
                    partSize = remainingSize < partSize ? remainingSize : partSize;
                }
            }
        }

        private static void Assemble(List<string> files, string destinationDirectory)
        {
            string outputPath = destinationDirectory + "assembled-result" + ".png";
            var outputFile = new FileStream(outputPath, FileMode.Create);
            outputFile.Close();

            using (outputFile = new FileStream(outputPath, FileMode.Append))
            {
                foreach (var file in files)
                {
                    using (var sourceFile = new FileStream(file, FileMode.Open))
                    {
                        using (var zipStream = new GZipStream(sourceFile, CompressionMode.Decompress, false))
                        {
                            Byte[] buffer = new byte[sourceFile.Length];
                            while (true)
                            {
                                int readBytes = zipStream.Read(buffer, 0, buffer.Length);
                                if (readBytes == 0)
                                {
                                    break;
                                }
                                outputFile.Write(buffer, 0, readBytes);
                            }
                        }
                    }
                }
            }
        }
    }
}
