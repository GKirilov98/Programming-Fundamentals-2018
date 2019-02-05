using System;
using System.Linq;

namespace Problem_06._Max_Sequence_of_Equal_Elements
{
    class MaxSeqOfEElement
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int bestCount = 0;
            int bestIndex = 0;
            TakeSameChar(inputArr, ref counter, ref bestCount, ref bestIndex);

            PrintSameIndex(inputArr, bestCount, bestIndex);

        }

        static void TakeSameChar(int[] inputArr, ref int counter, ref int bestCount, ref int bestIndex)
        {
            for (int i = 1; i < inputArr.Length; i++)
            {
                CheckSameChar(inputArr, ref counter, ref bestCount, ref bestIndex, i);
            }
        }

        static void PrintSameIndex(int[] inputArr, int bestCount, int bestIndex)
        {
            for (int j = bestIndex; j < bestIndex + bestCount; j++)
            {
                Console.Write(inputArr[j] + " ");
            }
        }

        static void CheckSameChar(int[] inputArr, ref int counter, ref int bestCount, ref int bestIndex, int i)
        {
            if (inputArr[i] == inputArr[i - 1])
            {
                counter++;
            }
            else
            {
                counter = 1;
            }
            if (counter > bestCount)
            {
                bestCount = counter;
                bestIndex = i - counter + 1;
            }
        }
    }
}
