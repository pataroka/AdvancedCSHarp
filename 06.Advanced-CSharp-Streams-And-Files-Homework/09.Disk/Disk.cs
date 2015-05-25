using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Disk
{
    class Disk
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int c = (int)Math.Floor(n / 2.0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    double x = Math.Sqrt((j - c) * (j - c) + (i - c) * (i - c));
                    Console.Write(x <= r ? "*" : ".");
                }
                Console.WriteLine();
            }
        }
    }
}
