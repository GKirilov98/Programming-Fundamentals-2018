using System;

namespace _03._Last_K_Numbers_Sums
{
    class LastKNumSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] numbers = new long[n];
            numbers[0] = 1;
            for (int i = 1; i < n; i++)
            {
                for (int j = i - 1; j >= 0 && j >= i - k; j--)
                {
                    numbers[i] += numbers[j];
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
