using System;

namespace Problem_10._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            if (times > 10)
            {
                int result = times * theInteger;
                Console.WriteLine($"{theInteger} X {times} = {result}" );
            }
            else
            {
                int result = 0;
                for (int i = times; i <= 10; i++)
                {
                    result = theInteger * i;
                    Console.WriteLine($"{theInteger} X {i} = {result}");
                }
            }
        }
    }
}
