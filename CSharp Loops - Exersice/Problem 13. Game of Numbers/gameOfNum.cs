using System;

namespace Problem_13._Game_of_Numbers
{
    class gameOfNum
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum= int.Parse(Console.ReadLine());
            int magicalNum= int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            int counter = 0;
            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int j = firstNum; j <= secondNum; j++)
                {
                    counter++;
                    if ( i + j == magicalNum)
                    {
                        a = i;
                        b = j;
                    }
                }
            }
            if ( a == 0 && b == 0)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicalNum}");
            } else
            {
                Console.WriteLine($"Number found! {a} + {b} = {magicalNum} ");
            }
        }
    }
}
