using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> input = Console.ReadLine().Split().ToList();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "3:1")
                {
                    break;
                }

                string[] tokens = line.Split();
                string command = tokens[0];
                if (command == "merge")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    if (startIndex > input.Count - 1)
                    {
                        startIndex = input.Count - 1;
                    }
                    else if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if (endIndex > input.Count - 1)
                    {
                        endIndex = input.Count - 1;
                    }
                    string merage = string.Empty;
                    for (int i = startIndex; i <= endIndex; endIndex--)
                    {
                        merage += input[i];
                        input.RemoveAt(i);
                    }

                    input.Insert(startIndex, merage);
                }
                else if (command == "divide")
                {
                    int index = int.Parse(tokens[1]);
                    int partitions = int.Parse(tokens[2]);


                    string element = input[index];
                    int groups = element.Length / partitions;

                    List<string> dividedPartitions = new List<string>();

                    for (int i = 0; i < partitions; i++)
                    {
                        if (i == partitions - 1)
                        {
                            dividedPartitions.Add(element.Substring(i * groups));
                        }
                        else
                        {
                            dividedPartitions.Add(element.Substring(i * groups, groups));
                        }
                    }

                    input.RemoveAt(index);
                    input.InsertRange(index, dividedPartitions);
                }
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
