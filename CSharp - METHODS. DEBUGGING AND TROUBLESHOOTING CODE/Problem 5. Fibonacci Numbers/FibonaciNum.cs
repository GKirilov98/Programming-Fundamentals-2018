using System;

namespace Problem_5._Fibonacci_Numbers
{
    class FibonaciNum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fibunacciNum = CalculateFib(n);
            Console.WriteLine(fibunacciNum);
        }

        static int CalculateFib(int n)
        {
            int result = 1;
            int beforeNum = 0;
            int afterNum = 1;
            for (int i = 0; i < n; i++)
            {
                result = beforeNum + afterNum;
                beforeNum = afterNum;
                afterNum = result;

            }

            return result;
        }
    }
}
