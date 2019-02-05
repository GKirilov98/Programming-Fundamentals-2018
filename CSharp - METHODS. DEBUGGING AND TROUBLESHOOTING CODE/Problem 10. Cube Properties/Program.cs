using System;

namespace Problem_10._Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideOfCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine().ToLower();

            switch (parameter)
            {
                case "face":
                    double resultFace = DiagonalFace(sideOfCube);
                    Console.WriteLine($"{resultFace:f2}");
                    break;
                case "space":
                    double resultSpace = DiagonalSpace(sideOfCube);
                    Console.WriteLine($"{resultSpace:f2}");
                    break;
                case "volume":
                    double resultVolume = DiagonalVolume(sideOfCube);
                    Console.WriteLine($"{resultVolume:f2}");
                    break;
                case "area":
                    double resultArea = DiagonalArea(sideOfCube);
                    Console.WriteLine($"{resultArea:f2}");
                    break;
            }
        }

        static double DiagonalArea(double sideOfCube)
        {
            double areaDiagonal = 6 * Math.Pow(sideOfCube, 2);
            return areaDiagonal;
        }

        static double DiagonalVolume(double sideOfCube)
        {
            double volumeDiagonal = Math.Pow(sideOfCube, 3);
            return volumeDiagonal;
        }

        private static double DiagonalSpace(double sideOfCube)
        {
            double spaceDiagonal = Math.Sqrt(3 * Math.Pow(sideOfCube, 2));
            return spaceDiagonal;
        }

        static double DiagonalFace(double sideOfCube)
        {

            double faceDiagonal = Math.Sqrt(2 * Math.Pow(sideOfCube, 2));
            return faceDiagonal;
        }
    }
}
