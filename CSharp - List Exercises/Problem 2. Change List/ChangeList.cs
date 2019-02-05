using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Change_List
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');
                if (command[0] == "Odd")
                {
                    foreach (int num in numbers)
                    {
                        if (num % 2 != 0)
                        {
                            Console.Write(num + " ");
                        }
                    }

                    break;
                }
                else if (command[0] == "Even")
                {
                    foreach (int num in numbers)
                    {
                        if (num % 2 == 0)
                        {
                            Console.Write(num + " ");
                        }
                    }

                    break;
                }

                switch (command[0])
                {
                    case "Delete":
                        int numToRemove = int.Parse(command[1]);
                        numbers.RemoveAll(n => n == numToRemove);
                        break;
                    case "Insert":
                        int element = int.Parse(command[1]);
                        int position = int.Parse(command[2]);
                        numbers.Insert(position, element);
                        break;
                }
            }
        }
    }
}