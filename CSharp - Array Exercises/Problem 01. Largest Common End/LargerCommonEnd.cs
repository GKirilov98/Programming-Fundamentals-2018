using System;
using System.Linq;

namespace Problem_01._Largest_Common_End
{
    class LargerCommonEnd
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondArr = Console.ReadLine().Split(' ');

            int minLenght = Math.Min(firstArr.Length, secondArr.Length);
            int counterLeft = 0;
            int counterRight = 0;

            for (int i = 0; i < minLenght; i++)
            {
                counterLeft = LeftCommon(firstArr, secondArr, counterLeft, i);
                counterRight = RightCommon(firstArr, secondArr, counterRight, i);
            }

            PrintCountCommon(counterLeft, counterRight);
        }

        static void PrintCountCommon(int counterLeft, int counterRight)
        {
            if (counterLeft >= counterRight)
            {
                Console.WriteLine(counterLeft);
            }
            else if (counterLeft < counterRight)
            {
                Console.WriteLine(counterRight);
            }
            else if (counterRight == 0 && counterLeft == 0)
            {
                Console.WriteLine('0');
            }
        }

        static int RightCommon(string[] firstArr, string[] secondArr, int counterRight, int i)
        {
            if (firstArr[firstArr.Length - 1 - i] == secondArr[secondArr.Length - 1 - i])
            {
                counterRight++;
            }

            return counterRight;
        }

        static int LeftCommon(string[] firstArr, string[] secondArr, int counterLeft, int i)
        {
            if (firstArr[i] == secondArr[i])
            {
                counterLeft++;
            }

            return counterLeft;
        }
    }
}
