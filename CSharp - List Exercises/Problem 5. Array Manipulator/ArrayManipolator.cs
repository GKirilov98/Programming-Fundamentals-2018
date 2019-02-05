using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5._Array_Manipulator
{
    class ArrayManipolator
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "print")
                {
                    Console.WriteLine("[{0}]", String.Join(", ", nums));
                    break;
                }

                string[] tokens = line.Split();
                string command = tokens[0];
                int index;
                int element;

                switch (command)
                {
                    case "add":
                        index = int.Parse(tokens[1]);
                        element = int.Parse(tokens[2]);
                        nums.Insert(index, element);
                        break;
                    case "addMany":
                        AddMany(nums, tokens);
                        break;
                }
            }
        }

        private static void AddMany(List<int> nums, string[] tokens)
        {
            int index = int.Parse(tokens[1]);
            List<int> numbersToAdd = new List<int>();
            for (int i = 2; i < tokens.Length; i++)
            {
                numbersToAdd.Add(int.Parse(tokens[i]));
            }
            nums.InsertRange(index, numbersToAdd);
        }
    }
}


