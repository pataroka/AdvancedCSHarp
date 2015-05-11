using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _12.ToTheStars
{
    class ToTheStars
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string[] firstStar = Console.ReadLine().Split(' ');
            string[] secondStar = Console.ReadLine().Split(' ');
            string[] thirdStar = Console.ReadLine().Split(' ');
            double[] normandy = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int moves = int.Parse(Console.ReadLine());

            for (int i = 0; i <= moves; i++)
            {
                if (PassStar(normandy[0], normandy[1], firstStar))
                {
                    Console.WriteLine(firstStar[0].ToLower());
                }
                else if (PassStar(normandy[0], normandy[1], secondStar))
                {
                    Console.WriteLine(secondStar[0].ToLower());
                }
                else if (PassStar(normandy[0], normandy[1], thirdStar))
                {
                    Console.WriteLine(thirdStar[0].ToLower());
                }
                else
                {
                    Console.WriteLine("space");
                }
                normandy[1] += 1.0;
            }
        }

        static bool PassStar(double x, double y, string[] star)
        {
            if ((x >= double.Parse(star[1]) - 1.0) && (x <= double.Parse(star[1]) + 1.0) &&
                   (y >= double.Parse(star[2]) - 1.0) && (y <= double.Parse(star[2]) + 1.0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
