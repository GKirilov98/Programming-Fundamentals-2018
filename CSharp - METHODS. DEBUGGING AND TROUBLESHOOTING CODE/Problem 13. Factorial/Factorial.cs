using System;
using System.Numerics;

namespace Problem_13._Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            BigInteger factorial = BigInteger.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 1; i <= factorial; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
            
        }
    }
}
