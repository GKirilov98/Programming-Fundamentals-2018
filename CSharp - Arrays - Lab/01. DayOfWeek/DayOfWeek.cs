using System;

namespace _01._DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            int numDay = int.Parse(Console.ReadLine());
            string[] weekDays =
                {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
                 };
            if (numDay < 1 || numDay > 7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(weekDays[numDay - 1]);
            }
        }
    }
}
