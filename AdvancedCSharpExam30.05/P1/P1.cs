using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P1
{
    class P1
    {
        static void Main(string[] args)
        {
            string[] input = Regex.Split(Console.ReadLine(), @"\s+");
            string[] command = Regex.Split(Console.ReadLine(), @"\s+");

            while (command[0] != "end")
            {
                if (command.Length == 5)
                {
                    int start = int.Parse(command[2]);
                    int count = int.Parse(command[4]);
                    if (start >= 0 && start < input.Length && count >= 0 && (start + count <= input.Length))
                    {
                        switch (command[0])
                        {
                            case "reverse":
                                Array.Reverse(input, start, count);
                                break;
                            case "sort":
                                Array.Sort(input, start, count);
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else
                {
                    int count = int.Parse(command[1]);
                    if (count >= 0)
                    {
                        switch (command[0])
                        {
                            case "rollLeft":
                                RollLeft(count, input);
                                break;
                            case "rollRight":
                                RollRight(count, input);
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }

                command = Regex.Split(Console.ReadLine(), @"\s+");
            }

            Console.WriteLine("[" + string.Join(", ", input) + "]");
        }

        private static void RollLeft(int count, string[] input)
        {
            int counter = count % input.Length;
            while (counter > 0)
            {
                string last = input[0];
                for (int i = 0; i < input.Length; i++)
                {
                    if (i == input.Length - 1)
                    {
                        input[i] = last;
                    }
                    else
                    {
                        input[i] = input[i + 1];
                    }
                }
                counter--;
            }
        }

        private static void RollRight(int count, string[] input)
        {
            int counter = count % input.Length;
            while (counter > 0)
            {
                string last = input[input.Length - 1];
                for (int i = input.Length - 1; i >= 0 ; i--)
                {
                    if (i == 0)
                    {
                        input[i] = last;
                    }
                    else
                    {
                        input[i] = input[i - 1];
                    }
                }
                counter--;
            }
        }
    }
}
