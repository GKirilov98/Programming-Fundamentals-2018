using System;
using System.Numerics;
using System.Text;
using System.Linq;
namespace Problem_1.Convert_from_base_10_to_base_N
{
    class Convert10toN
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int @base = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            StringBuilder converted = new StringBuilder();
            while (number > 0)  
            {
                BigInteger result = number % @base;
                converted.Append(result);
                number /= @base;
            }

            string reverse = new String(converted
                .ToString()
                .Reverse()
                .ToArray()
                );

            Console.WriteLine(reverse);
        }
    }
}
