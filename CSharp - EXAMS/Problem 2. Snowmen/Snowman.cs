using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Snowmen
{
    class Snowman
    {
        static void Main(string[] args)
        {

            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> loserList = new List<int>();

           
            while (true)
            {
                for (int i = 0; i < loserList.Count; i++)
                {
                    if (Math.Abs(loserList.Count - input.Count) == 1)
                    {
                        continue;
                    }

                    if (loserList.Contains(i))
                    {
                        continue;
                    }

                    int attackerIndex = i;
                    int targetIndex;
                    if (input[i] > input.Count)
                    {
                        targetIndex = input[i] % input.Count;
                    }
                    else
                    {
                        targetIndex = input[i];
                    }

                    int absDiff = Math.Abs(attackerIndex - targetIndex);
                    if (absDiff == 0)
                    {
                        Console.WriteLine($"{attackerIndex} performed harakiri");
                        loserList.Add(attackerIndex);
                        loserList.Distinct();
                    }
                    else if (absDiff % 2 == 0)
                    {
                        Console.WriteLine($"{attackerIndex} x {target} -> {winner} wins");
                    }
                }
            
           
            //if absoluteValue == 0  -----> Suicedes;
            // if (absoluteValue % 2 == 0) -> atacker win;
            // else if (absoluteValue % 2 != 0) -> target win;
            //print battle --->
            // if atacker lose can't attack but it can be target
            // index++
            // while 1 winner






            }
        }
    }
}
