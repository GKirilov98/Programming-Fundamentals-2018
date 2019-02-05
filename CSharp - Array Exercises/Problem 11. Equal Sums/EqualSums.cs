using System;
using System.Linq;

namespace Problem_11._Equal_Sums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;
                for (int left = 0; left < i; left++)
                {
                    leftSum += input[left];
                }

                for (int right = i + 1; right < input.Length; right++)
                {
                    rightSum += input[right];
                }
               
                if ( input.Length == 1)
                {
                    Console.WriteLine('0');
                    break;
                }
                else if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            if (leftSum != rightSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
