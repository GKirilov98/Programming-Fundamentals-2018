using System;
using System.Linq;

namespace Problem_02._Rotate_and_Sum
{
    class RotatedAndSum
    {
        static void Main(string[] args)
        {
            int[] nArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int arrayLenght = nArray.Length;
            int[] sum = new int[arrayLenght];
            for (int r = 0; r < k; r++)
            {
                RotatedArray(nArray);
                SumArray(nArray, arrayLenght, sum);
            }

            Console.WriteLine(String.Join(" ", sum));
        }

        static void SumArray(int[] nArray, int arrayLenght, int[] sum)
        {
            for (int i = 0; i < arrayLenght; i++)
            {
                sum[i] += nArray[i];
            }
        }

        static void RotatedArray(int[] nArray)
        {
            int last = nArray[nArray.Length - 1];
            for (int i = nArray.Length - 1; i > 0; i--)
            {
                nArray[i] = nArray[i - 1];
            }
            nArray[0] = last;
        }
    }
}
