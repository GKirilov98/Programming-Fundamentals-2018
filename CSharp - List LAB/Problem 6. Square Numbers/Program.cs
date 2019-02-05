using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6._Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> squareNum = new List<int>();
            foreach (var num in input)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squareNum.Add(num);
                }
            }
            squareNum.Sort();
            squareNum.Reverse();
            Console.WriteLine(String.Join(" ", squareNum));
        }
    }
}
