using System;

namespace Problem_15.__Neighbour_Wars
{
    class NeighbourWars
    {
        static void Main(string[] args)
        {
            int demagePesho = int.Parse(Console.ReadLine());
            int demageGosho= int.Parse(Console.ReadLine());
            int hpPesho = 100;
            int hpGosho = 100;
            int counter = 0;
            while (hpGosho > 0 && hpPesho > 0)
            {
                counter++;
                if (counter % 2 != 0)
                {
                    hpGosho -= demagePesho;
                    if (hpGosho > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {hpGosho} health.");
                    }
                } else
                {
                    hpPesho -= demageGosho;
                    if (hpPesho > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {hpPesho} health.");
                    }
                }
                if (counter % 3 == 0 && hpPesho > 0 && hpGosho > 0)
                {
                    hpGosho += 10;
                    hpPesho += 10;
                }
               
            }
            if (hpPesho > 0)
            {
                Console.WriteLine($"Pesho won in {counter}th round.");
            } else
            {
                Console.WriteLine($"Gosho won in {counter}th round.");
            }
        }
    }
}
