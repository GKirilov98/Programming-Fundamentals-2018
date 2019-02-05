using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_03._Immune_System
{
    class ImmuneSystem
    {
        static void Main(string[] args)
        {
            List<string> vName = new List<string>();
            List<int> vStrenght = new List<int>();
            List<int> vSeconds = new List<int>();
            List<int> health = new List<int>();

            int maxHealth = int.Parse(Console.ReadLine());
            int currHealth = maxHealth;
           
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                char[] virusChar = line.ToCharArray();
                int virusStrenght = virusChar.Sum(x => x) / 3;
                int secondsDefeat = 0;
                if (vName.Contains(line) == false)
                {
                    vName.Add(line);
                    vStrenght.Add(virusStrenght);

                    secondsDefeat = virusStrenght * virusChar.Length;
                    vSeconds.Add(secondsDefeat);
                }
                else
                {
                    vName.Add(line);
                    vStrenght.Add(virusStrenght);

                    secondsDefeat = (virusStrenght * virusChar.Length) / 3;
                    vSeconds.Add(secondsDefeat);
                }


                currHealth -= secondsDefeat;
                health.Add(currHealth);
                currHealth = currHealth + (int)(currHealth * 0.20);
                if (currHealth > maxHealth)
                {
                    currHealth = maxHealth;
                }

                int immuneDef = currHealth - virusStrenght;
                if (immuneDef < 0)
                {
                    break;
                }
            }


            for (int i = 0; i < vName.Count; i++)
            {
                int immuneHealth = health[i] + (int)(health[i] * 0.20);
                if (immuneHealth > maxHealth)
                {
                    immuneHealth = maxHealth;
                }
                int imuneDef = immuneHealth - vStrenght[i];
                if (imuneDef >= 0)
                {
                    int min = 0;
                    int sec = vSeconds[i];
                    if (sec > 59)
                    {
                        sec = vSeconds[i] % 60;
                        min = vSeconds[i] / 60;
                    }

                    Console.WriteLine($"Virus {vName[i]}: {vStrenght[i]} => {vSeconds[i]} seconds");
                    Console.WriteLine($"{vName[i]} defeated in {min}m {sec}s.");
                    Console.WriteLine($"Remaining health: {health[i]}");
                }
                else
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }
            }
            Console.WriteLine($"Final Health: {(health[health.Count - 1] + (int)(health[health.Count - 1] * 0.2))}");
        }
    }
}

