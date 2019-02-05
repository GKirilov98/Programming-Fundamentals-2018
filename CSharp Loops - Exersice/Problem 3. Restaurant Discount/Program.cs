using System;

namespace Problem_3._Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSice = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            if (groupSice > 120) {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            string hallName = "";
            double priceHall = 0;

            if ( groupSice < 50)
            {
                hallName = "Small Hall";
                priceHall = 2500;
            } else if (groupSice < 100)
            {
                hallName = "Terrace";
                priceHall = 5000;
            } else
            {
                hallName = "Great Hall";
                priceHall = 7500;
            }
            double pricePackage = 0;
            double discount = 1;

            switch (package)
            {
                case "Normal":
                    pricePackage = 500;
                    discount = 0.95;
                    break;
                case "Gold":
                    pricePackage = 750;
                    discount = 0.90;
                    break;
                case "Platinum":
                    pricePackage = 1000;
                    discount = 0.85;
                    break;
            }

            double pricePerPerson = ((priceHall + pricePackage) * discount) / (groupSice * 1.00);

            Console.WriteLine($"We can offer you the {hallName}\r\nThe price per person is {pricePerPerson:f2}$");



        }
    }
}
