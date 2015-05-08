using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NumberCalculations
{
    class NumberCalculations
    {
        static void Main(string[] args)
        {
            decimal[] decimals = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            double[] doubles = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Console.WriteLine(FindMinValue(decimals));
            Console.WriteLine(FindMinValue(doubles));
            Console.WriteLine(FindMaxValue(decimals));
            Console.WriteLine(FindMaxValue(doubles));
            Console.WriteLine(FindAvgValue(decimals));
            Console.WriteLine(FindAvgValue(doubles));
            Console.WriteLine(FindSum(decimals));
            Console.WriteLine(FindSum(doubles));
            Console.WriteLine(FindProduct(decimals));
            Console.WriteLine(FindProduct(doubles));
        }

        static decimal FindMinValue(decimal[] numbers)
        {
            decimal result = Decimal.MaxValue;

            foreach (decimal n in numbers)
            {
                result = (n < result) ? n : result;
            }
            return result;
        }

        static double FindMinValue(double[] numbers)
        {
            double result = Double.MaxValue;

            foreach (double n in numbers)
            {
                result = (n < result) ? n : result;
            }
            return result;
        }

        static decimal FindMaxValue(decimal[] numbers)
        {
            decimal result = Decimal.MinValue;

            foreach (decimal n in numbers)
            {
                result = (n > result) ? n : result;
            }
            return result;
        }

        static double FindMaxValue(double[] numbers)
        {
            double result = Double.MinValue;

            foreach (double n in numbers)
            {
                result = (n > result) ? n : result;
            }
            return result;
        }

        static decimal FindAvgValue(decimal[] numbers)
        {
            decimal result = 0;

            foreach (decimal n in numbers)
            {
                result += n;
            }
            result /= numbers.Length;
            return result;
        }

        static double FindAvgValue(double[] numbers)
        {
            double result = 0;

            foreach (double n in numbers)
            {
                result += n;
            }
            result /= numbers.Length;
            return result;
        }

        static decimal FindSum(decimal[] numbers)
        {
            decimal result = 0;

            foreach (decimal n in numbers)
            {
                result += n;
            }
            return result;
        }

        static double FindSum(double[] numbers)
        {
            double result = 0;

            foreach (double n in numbers)
            {
                result += n;
            }
            return result;
        }

        static decimal FindProduct(decimal[] numbers)
        {
            decimal result = 1;

            foreach (decimal n in numbers)
            {
                result *= n;
            }
            return result;
        }

        static double FindProduct(double[] numbers)
        {
            double result = 1;

            foreach (double n in numbers)
            {
                result *= n;
            }
            return result;
        }
    }
}
