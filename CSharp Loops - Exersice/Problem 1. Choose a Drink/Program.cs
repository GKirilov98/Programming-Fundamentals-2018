using System;

namespace Problem_1._Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int sum = int.Parse(Console.ReadLine()) ;
            double price = 0;
            if (profession == "Athlete")
            {
                price = 0.70;
            } else if (profession == "Businessman" || profession == "Businesswoman")
            {
                price = 1.0;
            } else if (profession == "SoftUni Student")
            {
                price = 1.70;
            }else
            {
                price = 1.20;
            }
            double moneySpent = sum * price;
            Console.WriteLine($"The {profession} has to pay {moneySpent:f2}.");
                
        }
    }
}
