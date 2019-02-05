using System;

namespace Problem_4._Beverage_Labels
{
    class bLabels
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            double energyTotal = energyContent * volume / 100.0;
            double sugarTotal = sugarContent * volume / 100.0;

            Console.WriteLine($"{volume}ml {name}:\n" +
                $"{energyTotal}kcal, {sugarTotal}g sugars");
        }
    }
}
