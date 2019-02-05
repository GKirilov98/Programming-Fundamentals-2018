using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_09._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> validItem = new Dictionary<string, int>();
            validItem.Add("shards", 0);
            validItem.Add("fragments", 0);
            validItem.Add("motes", 0);
            SortedDictionary<string, int> junkItem = new SortedDictionary<string, int>();
            bool isWin = true;
            while (isWin)
            {
                string[] tokens = Console.ReadLine()
                    .ToLower()
                    .Split()
                    .ToArray();

                for (int i = 0; i < tokens.Length - 1; i += 2)
                {
                    int quantity = int.Parse(tokens[i]);
                    string item = tokens[i + 1];

                    if (validItem.ContainsKey(item))
                    {
                        validItem[item] += quantity;
                        if (validItem["shards"] > 249)
                        {
                            validItem[item] -= 250;
                            Console.WriteLine("Shadowmourne obtained!");
                            isWin = false;
                            break;
                        }
                        else if (validItem["fragments"] > 249)
                        {
                            validItem[item] -= 250;
                            Console.WriteLine("Valanyr obtained!");
                            isWin = false;
                            break;
                        }
                        else if (validItem["motes"] > 249)
                        {
                            validItem[item] -= 250;
                            Console.WriteLine("Dragonwrath obtained!");
                            isWin = false;
                            break;
                        }
                    }
                    else
                    {
                        if (junkItem.ContainsKey(item) == false)
                        {
                            junkItem.Add(item, 0);
                        }

                        junkItem[item] += quantity;
                    }
                }
            }

            foreach (var item in validItem.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkItem.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
