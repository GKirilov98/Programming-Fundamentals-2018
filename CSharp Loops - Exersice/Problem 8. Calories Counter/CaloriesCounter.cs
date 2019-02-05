using System;

namespace Problem_8._Calories_Counter
{
    class CaloriesCounter

    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int calories = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                string food = Console.ReadLine().ToLower();
                if (food == "cheese")
                {
                    calories = 500;
                }
                else if (food == "tomato sauce")
                {
                    calories = 150;
                }
                else if (food == "salami")
                {
                    calories = 600;
                }
                else if (food == "pepper")
                {
                    calories = 50;
                }
                sum += calories;
                calories = 0;
            }
            Console.WriteLine($"Total calories: {sum}");
        }
    }
}
