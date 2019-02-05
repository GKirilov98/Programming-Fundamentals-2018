using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1._Remove_Negatives_and_Reverse
{
    class RemNegativReverse
    {
        static void Main(string[] args)
        {
            List<int> inputNumse = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < inputNumse.Count; )
            {
                if (inputNumse[i] < 0)
                {
                    inputNumse.RemoveAt(i);
                } 
                else
                {
                    i++;
                }
            }

            if (inputNumse.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                inputNumse.Reverse();
                Console.WriteLine(String.Join(" ", inputNumse));
            }
        }
    }
}
