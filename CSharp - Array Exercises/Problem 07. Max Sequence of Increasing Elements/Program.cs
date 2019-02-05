using System;
using System.Linq;

namespace Problem_07._Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int counter = 1;
            int maxCounter = 0;
            int index = 0;
            
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] <= input[i + 1] - 1)
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    index = i - counter + 1;
                    
                }
            }
            for (int i = index + 1; i <= index + maxCounter; i++)
            {
                Console.Write(input[i] + " ");
            }



        }
    }
}
