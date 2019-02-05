using System;
using System.Globalization;

namespace Problem_01._Day_of_Week
{
    class DayOfWeak
    {
        static void Main(string[] args)
        {
            string dateText = Console.ReadLine();
            DateTime dateWeak = DateTime.ParseExact(dateText, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(dateWeak.DayOfWeek);
        }
    }
}
