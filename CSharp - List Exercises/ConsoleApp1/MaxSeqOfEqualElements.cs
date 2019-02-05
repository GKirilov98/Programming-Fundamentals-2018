using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class MaxSeqOfEqualElements
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int counter = 1;
            int MaxCounter = 1;
            int numOfLenght = numbers[0];
            if (numbers.Count == 1)
            {
                Console.WriteLine(numbers[0]);
                return;
            }
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers [i - 1])
                {
                    counter++;
                    if (counter > MaxCounter)
                    {
                        MaxCounter = counter;
                        numOfLenght = numbers[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            for (int i = 0; i < MaxCounter; i++)
            {
                Console.Write(numOfLenght + " ");
            }
            

        }
    }
}
