using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.CategorizeNumbers
{
    class CategorizeNumbers
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            decimal[] numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            List<decimal> roundNums = new List<decimal>();
            List<decimal> floatNums = new List<decimal>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if ((numbers[i] % 1) == 0)
                {
                    roundNums.Add(numbers[i]);
                }
                else
                {
                    floatNums.Add(numbers[i]);
                }
            }

            Console.WriteLine("[" + string.Join(", ", floatNums) + "] -> min: {0}, max: {1}, sum: {2}, avg: {3:F2}",
                                floatNums.Min(), floatNums.Max(), floatNums.Sum(), floatNums.Average());

            Console.WriteLine("[" + string.Join(", ", roundNums) + "] -> min: {0}, max: {1}, sum: {2}, avg: {3:F2}",
                                roundNums.Min(), roundNums.Max(), (int)roundNums.Sum(), roundNums.Average());
        }
    }
}
