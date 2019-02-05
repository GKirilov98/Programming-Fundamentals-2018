using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_4___Anonymous_Cache
{
    class AnonymCache
    {
        static void Main(string[] args)
        {
            var setKeySize = new Dictionary<string, Dictionary<string, long>>();
            var cache = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "thetinggoesskrra")
                {
                    break;
                }
                FillSKS(setKeySize, cache, line);
            }
            Console.WriteLine();
            foreach (var set in setKeySize.OrderByDescending(x => x.Value.Values.Sum()))
            {
                if (set.Value.Values.Count() != 0)
                {
                    Console.WriteLine($"Data Set: {set.Key}, Total Size: {set.Value.Values.Sum()}");
                    foreach (var key in set.Value)
                    {
                        Console.WriteLine($"$.{key.Key}");

                    }
                }
                break;
            }

        }

        static void FillSKS(Dictionary<string, Dictionary<string, long>> setKeySize, Dictionary<string, Dictionary<string, long>> cache, string line)
        {
            string[] tokens = line.Split("->| ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            // line -> dataSet
            if (tokens.Length == 1)
            {
                if (setKeySize.ContainsKey(tokens[0]) == false)
                {
                    setKeySize.Add(tokens[0], new Dictionary<string, long>());
                }
               
                    //Add from cache into setKeysSet
                    if (cache.ContainsKey(tokens[0]) && setKeySize.ContainsKey(tokens[0]))
                    {
                        foreach (var set in cache)
                        {
                            if (set.Key == tokens[0])
                            {
                                foreach (var key in set.Value)
                                {
                                    setKeySize[tokens[0]].Add(key.Key, key.Value);
                                }

                            }
                        }
                    }
                
            }
            else // line -> dataKey, datsSize , dataSet
            {
                string dataSet = tokens[2];
                string dataKey = tokens[0];
                int dataSize = int.Parse(tokens[1]);
                if (setKeySize.ContainsKey(dataSet) == false)
                {
                    if (cache.ContainsKey(dataSet) == false)
                    {
                        cache.Add(dataSet, new Dictionary<string, long>());
                    }

                    cache[dataSet].Add(dataKey, dataSize);
                }
                else
                {
                    setKeySize[dataSet].Add(dataKey, dataSize);
                }
            }
        }
    }
}
