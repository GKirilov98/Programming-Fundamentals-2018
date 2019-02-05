using System;

namespace Problem_11._5_Different_Numbers
{
    class diffNum
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

             if  (secondNum - firstNum < 4)
            {
                Console.WriteLine("No");
                return;
            }
            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int k = firstNum + 1; k <= secondNum; k++)
                {
                    for (int l = firstNum + 2; l <= secondNum ; l++)
                    {
                        for (int j = firstNum + 3; j <= secondNum; j++)
                        {
                            for (int m = firstNum + 4; m <= secondNum; m++)
                            {
                                if ( i < k && k < l && l <j && j < m)
                                {
                                    Console.WriteLine($"{i} {k} {l} {j} {m}");
                                }
                            }
                        }
                    }
                }

            }

        }
    }
}
