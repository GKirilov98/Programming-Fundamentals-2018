using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_06._User_Logs
{
    class UserLog
    {
        static void Main(string[] args)
        {
           var output = new SortedDictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                CountIP(output, line);
            }

            foreach (var user in output)
            {
                Console.WriteLine(user.Key + ':');
                Console.Write(String
                    .Join(", ", user.Value.Select(ipCount => ipCount.Key + " => " + ipCount.Value)));
                Console.WriteLine('.');
            }
        }

        static void CountIP(SortedDictionary<string, Dictionary<string, int>> output, string line)
        {
            string[] token = line.Split(" =".ToCharArray());
            string user = token[token.Length - 1];
            string ip = token[1];
            if (output.ContainsKey(user) == false)
            {
                output.Add(user, new Dictionary<string, int>());
            }

            if (output[user].ContainsKey(ip) == false)
            {
                output[user][ip] = 0;
            }

            output[user][ip]++;
        }
    }
}
