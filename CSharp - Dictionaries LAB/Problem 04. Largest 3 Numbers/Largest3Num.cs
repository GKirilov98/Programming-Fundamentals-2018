using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_04._Largest_3_Numbers
{
    class Largest3Num
    {
        static void Main(string[] args)
        {
            List<double> numInput = Console.ReadLine().Split().Select(double.Parse).ToList();
            string threeNums = String.Join(" ", numInput.OrderByDescending(num => num).Take(3));
            Console.WriteLine( threeNums);
        }
    }
}
