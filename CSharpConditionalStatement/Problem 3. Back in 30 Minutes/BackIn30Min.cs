using System;

namespace Problem_3._Back_in_30_Minutes
{
    class BackIn30Min
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int after30mins = minutes + 30;
            if (after30mins > 59)
            {
                after30mins -= 60;
                hours++;
            }
            if (hours > 23)
            {
                hours -= 24;
            }
            Console.WriteLine($"{hours}:{after30mins:d2}");

        }
    }
}
