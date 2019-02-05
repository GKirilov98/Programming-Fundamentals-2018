using System;

namespace Problem_16._Comparing_floats
{
    class comparingFloats
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double difference = num1 - num2;
            if (Math.Abs(difference) <= 0.000001)
            {
                Console.WriteLine(true);
            }else
            {
                Console.WriteLine(false);
            }
        }
    }
}
