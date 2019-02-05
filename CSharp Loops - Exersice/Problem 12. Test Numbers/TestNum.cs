using System;

namespace Problem_12._Test_Numbers
{
    class TestNum
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int counter = 0;
            int result = 0;
            int totalSum = 0;
            for (int i = firstNum; i >= 1; i--)
            {
                for (int k = 1; k <= secondNum; k++)
                {
                    result = 3*(i * k);
                    totalSum += result;
                    counter++;
                    if (totalSum >= maxSum)
                    {
                        Console.WriteLine($"{counter} combinations\r\nSum: {totalSum} >= {maxSum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations\r\nSum: {totalSum}");

        }
    }
}
