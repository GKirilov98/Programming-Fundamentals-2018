using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_01._Count_Real_Numbers
{
    class CountRealNum
    {
        public static object Dictonaries { get; private set; }

        static void Main(string[] args)
        {
            double[] numList = Console.ReadLine()
               .Split(' ')
               .Select(double.Parse).ToArray();
            var numDict = new SortedDictionary<double, int>();
            foreach (var num in numList)
            {
                if (numDict.ContainsKey(num) ==  false)
                {
                    numDict[num] = 0;
                }
                numDict[num]++;
            }

            foreach (var item in numDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
