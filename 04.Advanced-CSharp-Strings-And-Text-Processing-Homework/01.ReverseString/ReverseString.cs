using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string reversedString = StringReverse(Console.ReadLine());
            Console.WriteLine(reversedString);
        }

        public static string StringReverse(string s)
        {
	        char[] arr = s.ToCharArray();
	        Array.Reverse(arr);
	        return new string(arr);
        }
    }
}
