using System;

namespace Problem_1__
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmploy = int.Parse(Console.ReadLine());
            int secondEmploy = int.Parse(Console.ReadLine());
            int thirdEmploy = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int hour = 0;
            while (students > 0)
            {
                hour++;
                students = students - firstEmploy - secondEmploy - thirdEmploy;
                if (hour % 4 == 0)
                {
                    hour++;
                }
            }
            Console.WriteLine($"Time needed: {hour}h.");
        }
    }
}
