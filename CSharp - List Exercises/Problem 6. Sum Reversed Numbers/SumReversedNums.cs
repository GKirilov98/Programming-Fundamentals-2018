using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6._Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console
                .ReadLine()
                .Split(' ');

            
            List<string> numChar = new List<string>();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char[] arr = input[i].ToCharArray();
                Array.Reverse(arr);
                string reversed = new string(arr);
                numChar.Add(reversed);
                sum += int.Parse(numChar[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
