using System;

namespace Problem_8._Sum_of_Odd_Numbers
{
    class SumOddNum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(count);
                sum += count;
                count += 2;
           
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
