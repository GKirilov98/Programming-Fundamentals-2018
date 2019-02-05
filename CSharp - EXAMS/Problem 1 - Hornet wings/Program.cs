using System;
using System.Numerics;

namespace Problem_1___Hornet_wings
{
    class Program
    {
        static void Main(string[] args)
        {
            uint wingFlaps = uint.Parse(Console.ReadLine());
            double movesPer1000 = double.Parse(Console.ReadLine());
            uint endurance = uint.Parse(Console.ReadLine());

            double distance = (wingFlaps / 1000.0) * movesPer1000;
            double hornetFlaps = wingFlaps / 100.0;
            double rest = (wingFlaps / endurance * 1.0) * 5;
            double seconds = hornetFlaps + rest;
            Console.WriteLine($"{distance:f2} m.\n" +
                $"{seconds} s.");

        }
    }
}
