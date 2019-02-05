using System;

namespace Problem_12._Rectangle_Properties
{
    class RetanglePropectories
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = 2 * width + 2 * height;
            double area = width * height;
            double diagonalPow = Math.Pow(width, 2) + Math.Pow(height, 2);
            double diagonal = Math.Sqrt(diagonalPow);
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
