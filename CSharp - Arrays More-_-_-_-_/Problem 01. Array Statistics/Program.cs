using System;
using System.Linq;

namespace Problem_01._Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxInt = int.MinValue;
            int minInt = int.MaxValue;
            int sum = 0;
            double avarage = 1.0;
            for (int i = 0; i < inputArr.Length; i++)
            {
                int curNum = inputArr[i];
                maxInt = GetMax(curNum, maxInt, i);
                minInt = GetMin(curNum, minInt, i);
                sum += curNum;
                avarage = (1.0 * sum) / inputArr.Length;
            }

            

            PrintValues(maxInt, minInt, sum, avarage);

        }

        static void PrintValues(int maxInt, int minInt, int sum, double avarage)
        {
            Console.WriteLine($"Min = {minInt}\r\nMax = {maxInt}\r\nSum = {sum}\r\nAverage = {avarage}");

           
        }

        static int GetMin(int curNum, int minInt, int i)
        {
            if (curNum < minInt)
            {
                minInt = curNum;
            }

            return minInt;
        }

        private static int GetMax(int curNum, int maxInt, int i)
        {
            if (curNum > maxInt)
            {
                maxInt = curNum;
            }

            return maxInt;
        }
    }
}
