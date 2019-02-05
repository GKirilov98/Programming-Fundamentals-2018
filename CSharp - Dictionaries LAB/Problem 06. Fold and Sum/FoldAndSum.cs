using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_06._Fold_and_Sum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            List<int> input = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int k = input.Count / 4;
            var left = input.Take(k).Reverse().ToList();
            input.Reverse();
            var right = input.Take(k).ToList();
            var row1 = left.Concat(right).ToList();
            input.Reverse();
            var midle = input.Skip(k).Take(2 * k).ToList();
            var sum = row1.Select((x, index) => x + midle[index]);
            Console.WriteLine(String.Join(" ", sum));


        }
    }
}
