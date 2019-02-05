using System;

namespace Problem_04._Sieve_of_Eratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primeValues = new bool[n + 1];
            for (int i = 0; i < primeValues.Length; i++)
            {
                primeValues[i] = true;
            }

            primeValues[0] = false;
            primeValues[1] = false;
            PrintPrime(primeValues);
        }

        static void PrintPrime(bool[] primeValues)
        {
            for (int i = 2; i < primeValues.Length; i++)
            {
                if (primeValues[i])
                {
                    Console.Write(i + " ");
                    for (int k = 2 * i; k < primeValues.Length; k += i)
                    {
                        primeValues[k] = false;
                    }
                }
            }
        }

       
    }
}
