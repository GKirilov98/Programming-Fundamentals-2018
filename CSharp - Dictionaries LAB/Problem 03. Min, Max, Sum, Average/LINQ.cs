using System;
using System.Linq;

namespace Problem_03._Min__Max__Sum__Average
{
    class LINQ
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum = {numbers.Sum()}\r\n" +
                $"Min = {numbers.Min()}\r\n" +
                $"Max = {numbers.Max()}\r\n" +
                $"Average = {numbers.Average()}\r\n");
        }
    }
}
