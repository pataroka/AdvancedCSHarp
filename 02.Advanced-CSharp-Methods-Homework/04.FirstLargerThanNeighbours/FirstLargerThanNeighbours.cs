using System;


namespace _04.FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        private static void Main(string[] args)
        {
            int[] sequenceOne = {1, 3, 4, 5, 1, 0, 5};
            int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1, 1 };

            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
        }

        static int GetIndexOfFirstElementLargerThanNeighbours(int[] numbers)
        {
            int result = -1;

            if (numbers.Length > 1)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i == 0)
                    {
                        if (numbers[i] > numbers[i + 1])
                        {
                            result = i;
                            goto End;
                        }
                    }
                    else if (i == numbers.Length - 1)
                    {
                        if (numbers[i] > numbers[i - 1])
                        {
                            result = i;
                            goto End;
                        }
                    }
                    else
                    {
                        if ((numbers[i] > numbers[i + 1]) && (numbers[i] > numbers[i - 1]))
                        {
                            result = i;
                            goto End;
                        }
                    }
                }
            }
            End:
            return result;
        }
    }
}
