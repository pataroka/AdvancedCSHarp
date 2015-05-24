using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader("../../text.txt"))
                {
                    int counter = 0;
                    String line = sr.ReadLine();
                    while (line != null)
                    {
                        if (counter%2 == 0)
                        {
                            Console.WriteLine(line);
                        }
                        line = sr.ReadLine();
                        counter++;
                    }
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
