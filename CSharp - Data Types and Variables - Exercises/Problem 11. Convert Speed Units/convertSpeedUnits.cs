using System;

namespace Problem_11._Convert_Speed_Units
{
    class convertSpeedUnits
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());

            int timeSeconds = (hours * 60 * 60) + (minutes * 60) + seconds;
            float metersPerSeconds = 1.0f * distance / timeSeconds;
            Console.WriteLine(metersPerSeconds);
            float timeHours = hours + (minutes / 60.0f) + (seconds / 3600.0f);
            float kmPerHours = (distance / 1000.0f) / timeHours;
            Console.WriteLine(kmPerHours);
            float milesPerHours = (distance / 1609.0f) / timeHours;
            Console.WriteLine(milesPerHours);
        }
    }
}
