using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LastDigitOfNumber
{
    class LastDigitOfNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetLastDigitAsWord(number));
        }

        static string GetLastDigitAsWord(int n)
        {
            string number = "" + n;
            string digit;

            switch (number[number.Length - 1])
            {
                case '1':
                    digit = "one";
                    break;
                case '2':
                    digit = "two";
                    break;
                case '3':
                    digit = "three";
                    break;
                case '4':
                    digit = "four";
                    break;
                case '5':
                    digit = "five";
                    break;
                case '6':
                    digit = "six";
                    break;
                case '7':
                    digit = "seven";
                    break;
                case '8':
                    digit = "eight";
                    break;
                case '9':
                    digit = "nine";
                    break;
                default:
                    digit = "zero";
                    break;
            }
            return digit;
        }
    }
}
