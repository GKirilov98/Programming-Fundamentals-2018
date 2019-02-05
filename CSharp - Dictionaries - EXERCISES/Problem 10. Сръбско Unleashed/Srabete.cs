using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_10._Сръбско_Unleashed
{
    class Srabete
    {
        static void Main(string[] args)
        {
            var venueSingerProfit = new Dictionary<string, Dictionary<string, long>>();
            string line = Console.ReadLine();
            while(line != "End")
            {
                string[] tokens = line.Split(" @").ToArray();
                if (tokens.Length == 2)
                {
                    string[] tokens2 = tokens[1].Split().ToArray();
                    if(tokens2.Length >= 3)
                    {
                        FillVenueSingerProfit(venueSingerProfit, tokens, tokens2);
                    }
                }
                line = Console.ReadLine();
            }
            foreach (var venue in venueSingerProfit)
            {
                Console.WriteLine(venue.Key);
                foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }

        static void FillVenueSingerProfit(Dictionary<string, Dictionary<string, long>> venueSingerProfit, string[] tokens, string[] tokens2)
        {
            string singer = tokens[0];
            string venue = String.Join(" ", tokens2.Take(tokens2.Length - 2));
            long price = long.Parse(tokens2[tokens2.Length - 2]);
            long count = long.Parse(tokens2[tokens2.Length - 1]);

            if (venueSingerProfit.ContainsKey(venue) == false)
            {
                venueSingerProfit.Add(venue, new Dictionary<string, long>());
            }

            if (venueSingerProfit[venue].ContainsKey(singer) == false)
            {
                venueSingerProfit[venue].Add(singer, 0);
            }

            venueSingerProfit[venue][singer] += price * count;
        }
    }
}
