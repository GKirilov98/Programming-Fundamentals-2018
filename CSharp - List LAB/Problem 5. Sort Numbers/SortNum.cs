using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5._Sort_Numbers
{
    class SortNum
    {
        static void Main(string[] args)
        {
            List<double> nums = Console
                .ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            nums.Sort();
            Console.WriteLine(String.Join(" <= ", nums));
        }
    }
}
