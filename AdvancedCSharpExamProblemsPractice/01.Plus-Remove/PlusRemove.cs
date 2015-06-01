using System;
using System.Collections.Generic;

namespace _01.Plus_Remove
{
    class PlusRemove
    {
        static void Main(string[] args)
        {
            var inputList = new List<char[]>();

            string line = Console.ReadLine();

            while (line != "END")
            {
                inputList.Add(line.ToCharArray());
                line = Console.ReadLine();
            }
            var resultList = new List<char[]>();

            for (int i = 0; i < inputList.Count; i++)
            {
                char[] temp = new char[inputList[i].Length];
                for (int j = 0; j < inputList[i].Length; j++)
                {
                    temp[j] = inputList[i][j];
                }
                resultList.Add(temp);
            }


            for (int row = 1; row < inputList.Count - 1; row++)
            {
                for (int col = 1; col < inputList[row].Length - 1; col++)
                {
                    if ((col < inputList[row - 1].Length) && (col < inputList[row + 1].Length))
                    {
                        if ((char.ToLower(inputList[row][col]) == char.ToLower(inputList[row][col - 1])) &&
                           (char.ToLower(inputList[row][col]) == char.ToLower(inputList[row][col + 1])) &&
                           (char.ToLower(inputList[row][col]) == char.ToLower(inputList[row - 1][col])) &&
                           (char.ToLower(inputList[row][col]) == char.ToLower(inputList[row + 1][col])))
                        {
                            resultList[row][col] = resultList[row][col - 1] = resultList[row][col + 1] = resultList[row - 1][col] =
                                resultList[row + 1][col] = '\0';
                        }
                    }

                }
            }

            for (int i = 0; i < resultList.Count; i++)
            {
                string result = new string(resultList[i]);
                result = result.Replace("\0", "");
                Console.WriteLine(result);
            }


        }
    }
}