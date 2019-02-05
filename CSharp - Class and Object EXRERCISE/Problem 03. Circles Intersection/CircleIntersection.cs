using System;
using System.Linq;

namespace Problem_03._Circles_Intersection
{
    class CircleIntersection
    {
        static void Main(string[] args)
        { // 90/100 points in Judge
            Circle circle1 = ReadCircle();
            Circle circle2 = ReadCircle();

            double dictance = Circle.DistanceBetween(circle1, circle2);
            double raduises = Circle.SumRadius(circle1, circle2);
            if (dictance <= raduises)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static Circle ReadCircle()
        {
            double[] tokens = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            double x = tokens[0];
            double y = tokens[1];
            double r = tokens[2];

            Point point = new Point(x, y);
            Circle circle = new Circle(point, r);
            return circle;
        }

    }

    class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    class Circle
    {
        public Point Center { get; set; }

        public double Radius { get; set; }

        public Circle(Point center, double radius)
        {
            this.Center = center;
            this.Radius = radius;
        }

        public static double DistanceBetween(Circle p1, Circle p2)
        {
            double distance = Math.Sqrt(Math.Pow(p2.Center.Y - p2.Center.Y, 2) + Math.Pow(p2.Center.X - p1.Center.X, 2));
            return distance;
        }

        public static double SumRadius(Circle raduis1, Circle radius2)
        {
            double sum = raduis1.Radius + radius2.Radius;
            return sum;
        }
    }
}
