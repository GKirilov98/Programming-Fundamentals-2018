using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Search_for_a_Number
{
    class SearchForANum
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int[] command = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            List<int> collection = new List<int>();
            int firstNum = command[0];
            for (int i = 0; i < firstNum; i++)
            {
                collection.Add(numbers[i]);
            }

            int secondNum = command[1];
            for (int i = 0; i < secondNum; secondNum --)
            {
                collection.RemoveAt(i);
                i = 0;
            }

            int lastNum = command[2];
            bool containNum = collection.Remove(lastNum);
            if (containNum == true)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
