using System;
using System.Linq;

namespace Problem_08._Most_Frequent_Number
{
    class MostFreqNum
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxCounter = 0;
            int index = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int counter = 0;
                for (int j = i ; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        counter++;
                    }
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    index = i;
                }
            }

            Console.WriteLine(input[index]);
        }
    }
}
