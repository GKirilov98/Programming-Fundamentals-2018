using System;

namespace Problem_4._Hotel
{
    class hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceDouble = 0;
            double priceSuite= 0;
            double discount = 1;

            switch (month)
            {
                case "May":
                case "October":
                    if (nightCount > 7)
                    {
                        priceStudio = 50 * 0.95;
                    }
                    else
                    {
                        priceStudio = 50;
                    }
                    priceDouble = 65;
                    priceSuite = 75;
                    break;
                case "June":
                case "September":
                    priceStudio = 60;
                    if (nightCount > 14)
                    {
                        priceDouble = 72 * 0.90;
                    }
                    else
                    {
                        priceDouble = 72;
                    }
                    priceSuite = 82;
                    break;
                case "July":
                case "August":
                case "December":
                    priceStudio = 68;
                    priceDouble = 77;
                    if (nightCount > 14)
                    {
                        priceSuite = 89 * 0.85;
                    }
                    else
                    {
                        priceSuite = 89;
                    }
                    break;
            }

            double doubleStay = priceDouble * nightCount;
            double suitStay = priceSuite * nightCount;
            if (nightCount > 7 && (month == "September" || month == "October"))
            {
                nightCount--;
            }
            double studioStay = priceStudio * nightCount;

            Console.WriteLine($"Studio: {studioStay:f2} lv.\r\nDouble: {doubleStay:f2} lv.\r\nSuite: {suitStay:f2} lv.");
            
        }
    }
}
