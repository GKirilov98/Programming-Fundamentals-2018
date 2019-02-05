using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_08._Logs_Aggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
           var logs = new SortedDictionary<string, SortedDictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string ip = tokens[0];
                string user = tokens[1];
                int duration = int.Parse(tokens[2]);

                if (logs.ContainsKey(user) == false)
                {
                    logs.Add(user, new SortedDictionary<string, int>());
                }

                if (logs[user].ContainsKey(ip) == false)
                {
                    logs[user].Add(ip, 0);
                }

                logs[user][ip] += duration;
            }

            foreach (var user in logs)
            {
                int allDuration = 0;
                foreach (var item in user.Value)
                {
                    allDuration += item.Value;
                }
                Console.WriteLine($"{user.Key}: {allDuration} [{String.Join(", ", user.Value.Keys)}]");
            }
        }
    }
}
