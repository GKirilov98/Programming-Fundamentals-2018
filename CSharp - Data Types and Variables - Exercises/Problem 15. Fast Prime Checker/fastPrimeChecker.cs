using System;

namespace Problem_15._Fast_Prime_Checker
{
    class fastPrimeChecker
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                bool check = true;
                for (int m = 2; m <= Math.Sqrt(i); m++)
                {
                    if (i % m == 0)
                    {
                        check = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {check}");
            }

        }
    }
}
