using System;
using System.Globalization;
using System.Linq;

namespace Problem_01._Count_Working_Days
{
    class CountWorkingDays
    {
        static void Main(string[] args)
        {
            DateTime[] holydays =
            {
              new DateTime (1, 1, 4),
              new DateTime (3, 3, 4),
              new DateTime (1, 5, 4),
              new DateTime (6, 5, 4),
              new DateTime (24, 5, 4),
              new DateTime (6, 9, 4),
              new DateTime (22, 9, 4),
              new DateTime (1, 11, 4),
              new DateTime (24, 12, 4),
              new DateTime (25, 12, 4),
              new DateTime (26, 12, 4)
            };

            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int count = 0;
            for (DateTime day = start; day <= end; day = day.AddDays(1))
            {
                DateTime currDate = new DateTime(day.Day, day.Month, 4);
                if (day.DayOfWeek == DayOfWeek.Saturday ||
                    day.DayOfWeek == DayOfWeek.Sunday)
                {
                    continue;
                }
                else if (holydays.Contains(currDate))
                {
                    continue;
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
