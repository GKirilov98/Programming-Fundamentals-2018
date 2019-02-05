using System;

namespace Problem_6._Prime_Checker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            
            Console.WriteLine(IsPrime(num));
        }

        private static bool IsPrime(long num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
