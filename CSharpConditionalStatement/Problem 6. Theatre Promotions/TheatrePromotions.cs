using System;

namespace Problem_6._Theatre_Promotions
{
    class TheatrePromotions
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine().ToLower();
            int agePerson = int.Parse(Console.ReadLine());

            if (agePerson < 0 || agePerson > 122)
            {
                Console.WriteLine("Error!");
                return;
            
            }
            int price = 0;
            switch (dayType)
            {
                case "weekday":
                    if (agePerson <= 18)
                    {
                        price = 12;

                    } else if (agePerson <= 64)
                    {
                        price = 18;
                    }
                    else
                    {
                        price = 12;
                    }
                    break;
                case "weekend":
                    if (agePerson <= 18)
                    {
                        price = 15;

                    }
                    else if (agePerson <= 64)
                    {
                        price = 20;
                    }
                    else
                    {
                        price = 15;
                    }
                    break;
                case "holiday":
                    if (agePerson <= 18)
                    {
                        price = 5;

                    }
                    else if (agePerson <= 64)
                    {
                        price = 12;
                    }
                    else
                    {
                        price = 10;
                    }
                    break;
            }

            Console.WriteLine($"{price}$");

        }
    }
}
