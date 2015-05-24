using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            StreamReader read = StreamReader.Null;
            StreamWriter write = StreamWriter.Null;
            string line;
            int lineNumber = 0;

            try
            {
                read = new StreamReader("../../text.txt");
                write = new StreamWriter("../../numbered_text.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read/created:");
                Console.WriteLine(e.Message);
            }
            
            using (read)
            using (write)
            {
                line = read.ReadLine();
                while (line != null)
                {
                    write.WriteLine("{0,4}  {1}", lineNumber, line);
                    lineNumber++;
                    line = read.ReadLine();
                }
            }
            Console.WriteLine("Success!");
        }
    }
}
