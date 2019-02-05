using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Hornet_Assault
{
    class HornetAssaut
    {
        static void Main(string[] args)
        {
            List<int> bees = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> hornets = Console.ReadLine().Split().Select(int.Parse).ToList();
            //20 -> 5, 10, 5, 3
            for (int b = 0; b < bees.Count; b++)
            {
                for (int h = 0; h < hornets.Count; h++)
                {
                    bees[b] -= hornets[h];
                    if (bees[b] >= 0)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                if (bees[b] >= 0)
                {
                    hornets.RemoveAt(0);
                }
                else
                {
                    bees.RemoveAt(b);
                    b--;
                }
            }
            Console.WriteLine();
        }
    }
}
