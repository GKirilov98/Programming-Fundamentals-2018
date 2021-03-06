﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Sum_Adjacent_Equal_Numbers
{
    class SumAdjEqualNum
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console
                .ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count -1; i++)
            {
                if (numbers [i] == numbers [i + 1])
                {
                    double sum = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i);
                    numbers.RemoveAt(i);
                    numbers.Insert(i, sum);
                    i = -1;
                }
            }
            Console.WriteLine(String.Join(' ', numbers));
        }
    }
}
