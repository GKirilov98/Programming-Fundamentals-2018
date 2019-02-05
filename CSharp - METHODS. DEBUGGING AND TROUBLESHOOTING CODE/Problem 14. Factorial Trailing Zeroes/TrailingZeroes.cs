using System;
using System.Numerics;

namespace Problem_14._Factorial_Trailing_Zeroes
{
    class TrailingZeroes
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger result = ToFactorial(number);
            int count = TreilingZeroes(result);
            Console.WriteLine(count);

        }

        private static int TreilingZeroes (BigInteger result)
        {
            int count = 0;
            while (result % 10 == 0)
            {
                result /= 10;
                count++;
            }

            return count;
        }

        static BigInteger ToFactorial(BigInteger number)
        {
            BigInteger result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}


