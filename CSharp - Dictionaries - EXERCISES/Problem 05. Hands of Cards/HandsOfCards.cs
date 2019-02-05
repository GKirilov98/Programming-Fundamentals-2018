using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_HandsOfCards
{
    class P05_HandsOfCards
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, List<string>>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "JOKER")
                {
                    break;
                }

                GetCards(players, line);
            }

            var power = new Dictionary<string, int>();
            GetPow(power);

            foreach (var player in players)
            {
                int sum = 0;
                var cards = player.Value.Distinct().ToList();

                sum = GetSum(power, sum, cards);

                Console.WriteLine($"{player.Key}: {sum}");
            }
        }

        static int GetSum(Dictionary<string, int> power, int sum, List<string> cards)
        {
            foreach (string card in cards)
            {
                string powerCardNum = card[0].ToString();
                string powerSuitNum = card[card.Length - 1].ToString();

                int cardPow = power[powerCardNum];
                int cardSuit = power[powerSuitNum];

                sum += cardPow * cardSuit;
            }

            return sum;
        }

        static void GetPow(Dictionary<string, int> power)
        {
            for (int i = 2; i <= 9; i++)
            {
                power.Add($"{i}", i);
            }

            power.Add("1", 10);
            power.Add("J", 11);
            power.Add("Q", 12);
            power.Add("K", 13);
            power.Add("A", 14);

            power.Add("S", 4);
            power.Add("H", 3);
            power.Add("D", 2);
            power.Add("C", 1);
        }

        static void GetCards(Dictionary<string, List<string>> players, string line)
        {
            string[] tokens = line.Split(':');
            string playerName = tokens[0];
            string[] cards = tokens[1].Trim().Split(", ");
            if (players.ContainsKey(playerName) == false)
            {
                players.Add(playerName, new List<string>());
            }

            players[playerName].AddRange(cards.Distinct());
        }
    }
}