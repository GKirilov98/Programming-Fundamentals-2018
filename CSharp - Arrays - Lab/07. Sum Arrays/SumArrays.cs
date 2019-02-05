using System;
using System.Linq;

namespace _07._Sum_Arrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] firsttArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int stop = Math.Max(firsttArr.Length, secondArr.Length);
            int[] sumArr = new int[stop];
            for (int i = 0; i < stop; i++)
            {
                sumArr[i] = firsttArr[i % firsttArr.Length] + secondArr[i % secondArr.Length];
            }
            Console.WriteLine(String.Join(" ", sumArr));
        }
    }
}
