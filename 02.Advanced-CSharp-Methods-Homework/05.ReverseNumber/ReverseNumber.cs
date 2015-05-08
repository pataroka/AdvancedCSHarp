using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ReverseNumber
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            double input = Double.Parse(Console.ReadLine());

            Console.WriteLine(ReverseDouble(input));
        }

        static double ReverseDouble(double number)
        {
            char[] arr = number.ToString().ToCharArray();
            Array.Reverse(arr);
            return Convert.ToDouble(new string(arr));
        }
    }
}
