using System;
using System.Linq;

namespace Problem_03._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int divisorArr = inputArr.Length / 4;
            int stopI = inputArr.Length - divisorArr;

            int[] firstArr = new int[inputArr.Length / 2];
            int[] secondArr = new int[inputArr.Length / 2];
            int[] sumArr = new int[inputArr.Length / 2];

            GetFirstArr(inputArr, divisorArr, stopI, firstArr);
            GetSecondArr(inputArr, divisorArr, stopI, secondArr);
            GetSumArr(inputArr, firstArr, secondArr, sumArr);

            Console.WriteLine(String.Join(" ",sumArr));
        }

        static void GetSumArr(int[] inputArr, int[] firstArr, int[] secondArr, int[] sumArr)
        {
            for (int i = 0; i < inputArr.Length / 2; i++)
            {
                sumArr[i] = firstArr[i] + secondArr[i];
            }
        }

        static void GetSecondArr(int[] inputArr, int divisorArr, int stopI, int[] secondArr)
        {
            for (int i = divisorArr; i < stopI; i++)
            {
                secondArr[i - divisorArr] = inputArr[i];
            }
        }

        static void GetFirstArr(int[] inputArr, int divisorArr, int stopI, int[] firstArr)
        {
            int rotade = divisorArr;
            for (int i = 0; i < divisorArr; i++)
            {
                rotade--;
                firstArr[rotade] = inputArr[i];
            }

            int counter = inputArr.Length / 2;
            for (int i = stopI; i < inputArr.Length; i++)
            {
                counter--;
                firstArr[counter] = inputArr[i];
            }
        }
    }
}
