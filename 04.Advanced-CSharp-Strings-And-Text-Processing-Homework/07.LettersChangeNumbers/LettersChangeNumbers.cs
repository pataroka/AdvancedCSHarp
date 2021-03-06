﻿using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace _07.LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Regex.Split(Console.ReadLine().Trim(), @"\s+");
            decimal total = 0;

            foreach (string str in input)
            {
                decimal number = Convert.ToDecimal(str.Substring(1, str.Length - 2));

                if (Char.IsLower(str.First()))
                {
                    number *= (decimal)str.First() - 96;
                }
                else
                {
                    number /= (decimal)str.First() - 64;
                }

                if (Char.IsLower(str.Last()))
                {
                    number += (decimal)str.Last() - 96;
                }
                else
                {
                    number -= (decimal)str.Last() - 64;
                }

                total += number;
            }
            Console.WriteLine("{0:F2}", total);
        }
    }
}