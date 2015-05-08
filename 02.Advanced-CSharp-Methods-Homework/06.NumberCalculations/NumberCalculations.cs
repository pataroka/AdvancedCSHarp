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
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            double[] doubles = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Console.WriteLine(FindMinValue(ints));
            Console.WriteLine(FindMinValue(doubles));
            Console.WriteLine(FindMaxValue(ints));
            Console.WriteLine(FindMaxValue(doubles));
            Console.WriteLine(FindAvgValue(ints));
            Console.WriteLine(FindAvgValue(doubles));
            Console.WriteLine(FindSum(ints));
            Console.WriteLine(FindSum(doubles));
            Console.WriteLine(FindProduct(ints));
            Console.WriteLine(FindProduct(doubles));
        }

        static int FindMinValue(int[] numbers)
        {
            int result = Int32.MaxValue;

            foreach (int n in numbers)
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

        static int FindMaxValue(int[] numbers)
        {
            int result = Int32.MinValue;

            foreach (int n in numbers)
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

        static int FindAvgValue(int[] numbers)
        {
            long result = 0;

            foreach (int n in numbers)
            {
                result += n;
            }
            result /= numbers.Length;
            return (int)result;
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

        static long FindSum(int[] numbers)
        {
            long result = 0;

            foreach (int n in numbers)
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

        static long FindProduct(int[] numbers)
        {
            long result = 0;

            foreach (int n in numbers)
            {
                result *= n;
            }
            return result;
        }

        static double FindProduct(double[] numbers)
        {
            double result = 0;

            foreach (double n in numbers)
            {
                result *= n;
            }
            return result;
        }
    }
}
