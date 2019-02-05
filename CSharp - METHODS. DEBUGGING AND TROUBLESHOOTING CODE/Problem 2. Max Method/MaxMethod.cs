using System;

namespace Problem_2._Max_Method
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
           int result = GetMax(num1,num2,num3);
            Console.WriteLine(result);
        }

        static int GetMax(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if(num2 > num3 && num2 > num1)
            {
                return num2;
            }
            else
            {
                return num3;
            }
            
        }
    }
}
