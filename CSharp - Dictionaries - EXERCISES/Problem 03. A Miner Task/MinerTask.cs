using System;
using System.Collections.Generic;
namespace Problem_03._A_Miner_Task
{
    class MinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> miner = new Dictionary<string, int>();
            string resources = Console.ReadLine();
            while (resources != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (miner.ContainsKey(resources))
                {
                    miner[resources] = miner[resources] + quantity;
                }
                else
                {
                    miner[resources] = quantity;
                }

                resources = Console.ReadLine();
            }

            foreach (var resource in miner)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
