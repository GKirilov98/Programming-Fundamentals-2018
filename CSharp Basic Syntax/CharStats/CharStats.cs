using System;

namespace CharStats
{
    class CharStats
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}\n" +
                "Health: |" + new string('|', currentHealth) + new string('.', maximumHealth - currentHealth) + "|\n" + "Energy: |" + new string('|', currentEnergy) + new string('.', maximumEnergy - currentEnergy) + '|');
        }
    }
}
