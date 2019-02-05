using System;

namespace Problem_11._Geometry_Calculator
{
    class GeometryCalcolator
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();
            switch (figure)
            {
                case "triangle":
                    double resultTriangle = TriangleArea();
                    Console.WriteLine($"{resultTriangle:f2}");
                    break;
                case "square":
                    double resultSquare = SquareArea();
                    Console.WriteLine($"{resultSquare:f2}");
                    break;
                case "rectangle":
                    double resultRectangle = RectangleArea();
                    Console.WriteLine($"{resultRectangle:f2}");
                    break;
                case "circle":
                    double resultCircle = CircleArea();
                    Console.WriteLine($"{resultCircle:f2}");
                    break;
            }
        }

        static double CircleArea()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        static double RectangleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            return area;
        }

        static double SquareArea()
        {
            double side = double.Parse(Console.ReadLine());
            double area = side * side;
            return area;
        }

        static double TriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = side * height / 2.0;
            return area;
        }
    }
}
