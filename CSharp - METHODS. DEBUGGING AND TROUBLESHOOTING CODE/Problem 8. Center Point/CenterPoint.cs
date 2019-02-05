using System;

namespace Problem_8._Center_Point
{
    class CenterPointCordinateSystem
    {
        static void Main(string[] args)
        {
            CenterPointCordinate();


        }

        static void CenterPointCordinate()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double result1 = Math.Pow(x1, 2) + Math.Pow(y1, 2);
            double result2 = Math.Pow(x2, 2) + Math.Pow(y2, 2);

            if (result1 == 4)
            {
                Console.WriteLine($"({x1}, {y1})");
                return;
            }
            else if (result2 == 4)
            {
                Console.WriteLine($"({x2}, {y2})");
                return;
            }

            if (result1 > 4 && result2 > 4)
            {
                if (result1 >= result2)
                {
                    Console.WriteLine($"({x2}, {y2})");
                    return;
                }
                else if (result2 > result1)
                {
                    Console.WriteLine($"({x1}, {y1})");
                    return;
                }
            }
            else if (result1 < 4 || result2 < 4)
            {
                double min1 = Math.Abs(result1 - 4);
                double min2 = Math.Abs(result2 - 4);
                if (min1 < min2)
                {
                    Console.WriteLine($"({x1}, {y1})");
                    return;
                } else
                {
                    Console.WriteLine($"({x2}, {y2})");
                    return;
                }
            }
        }
    }
}

