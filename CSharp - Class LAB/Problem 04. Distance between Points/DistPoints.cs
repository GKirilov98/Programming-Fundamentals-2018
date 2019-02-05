using System;
using System.Linq;
namespace Problem_04._Distance_between_Points
{
    class DistPoints
    {
        static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();

            double distance = Point.CalculateDistanceBetweenTwoLines(p1, p2);

            Console.WriteLine($"{distance:F3}");
        }

        private static Point ReadPoint()
        {
            int[] coordinate = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Point points = new Point(coordinate[0], coordinate[1]);
            return points;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
       
        public static double CalculateDistanceBetweenTwoLines(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }
    }
}
