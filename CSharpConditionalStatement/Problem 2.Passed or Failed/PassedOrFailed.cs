﻿using System;

namespace Problem_2.Passed_or_Failed
{
    class PassedOrFailed
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            } else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
