using System;
using System.Collections.Generic;
using System.Text;

namespace _06.X_Removal
{
    class XRemoval
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<bool[]> boolList = new List<bool[]>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                list.Add(input);
                boolList.Add(new bool[input.Length]);
                input = Console.ReadLine();
            }
            
            for (int row = 0; row < list.Count - 2; row++)
            {
                for (int col = 0; col < list[row].Length - 2; col++)
                {
                    if (col + 1 < list[row + 1].Length &&
                        col < list[row + 2].Length &&
                        col + 2 < list[row + 2].Length) 
                    {
                        if (Char.ToLower(list[row][col]) == Char.ToLower(list[row][col + 2]) &&
                            Char.ToLower(list[row][col]) == Char.ToLower(list[row + 1][col + 1]) &&
                            Char.ToLower(list[row][col]) == Char.ToLower(list[row + 2][col]) &&
                            Char.ToLower(list[row][col]) == Char.ToLower(list[row + 2][col + 2])) 
                        {

                            boolList[row][col] = boolList[row][col + 2] =
                                boolList[row + 1][col + 1] = boolList[row + 2][col] =
                                    boolList[row + 2][col + 2] = true;
                        }
                    }
                }
            }

            StringBuilder output = new StringBuilder();

            for (int row = 0; row < boolList.Count; row++)
            {
                for (int col = 0; col < boolList[row].Length; col++)
                {
                    if (!boolList[row][col])
                    {
                        output.Append(list[row][col]);
                    }
                }
                output.Append('\n');
            }

            Console.WriteLine(output.ToString());

        }
    }
}
