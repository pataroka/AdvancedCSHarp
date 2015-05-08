using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GenericArraySort
{
    class GenericArraySort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence of numbers separated by a space:");
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine("Enter a sequence of strings separated by a space:");
            string[] strings = Console.ReadLine().Split(' ');
            Console.WriteLine("Enter a sequence of dates separated by a space:");
            DateTime[] dates = Array.ConvertAll(Console.ReadLine().Split(' '), DateTime.Parse);

            SortArray(numbers);
            Console.WriteLine(string.Join(" ", numbers));
            SortArray(strings);
            Console.WriteLine(string.Join(" ", strings));
            SortArray(dates);
            Console.WriteLine(string.Join(" ", dates));
        }

        static T[] SortArray<T>(T[] arr) where T : IComparable<T>
        {
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                T minValue = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (minValue.CompareTo(arr[j]) == 1)
                    {
                        minValue = arr[j];
                        index = j;
                    }
                }

                if (minValue.CompareTo(arr[i]) == -1)
                {
                    T temp = arr[i];
                    arr[i] = minValue;
                    arr[index] = temp;
                }
            }
            return arr;
        }
    }
}
