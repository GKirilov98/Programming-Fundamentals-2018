using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerPool = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] tokens = Console.ReadLine().Split("->");
                if (tokens[0] == "Season end") break;
                if (tokens.Length == 3)
                {
                    AddPlayer(playerPool, tokens);
                }
                else
                {
                    tokens = tokens[0].Split("vs");
                    if (tokens.Length == 2)
                    {
                        string firstPlayer = tokens[0].Trim();
                        string secondPlayer = tokens[1].Trim();

                        if (playerPool.ContainsKey(firstPlayer) &&
                            playerPool.ContainsKey(secondPlayer))
                        {

                            List<string> positionFirstPlayer = new List<string>();
                            foreach (var player in playerPool)
                            {
                                if (player.Key == firstPlayer)
                                {
                                    foreach (var position in player.Value)
                                    {
                                        positionFirstPlayer.Add(position.Key);
                                    }
                                    break;
                                }
                            }

                            bool isCommon = false;
                            for (int i = 0; i < positionFirstPlayer.Count; i++)
                            {
                                if (playerPool[secondPlayer].ContainsKey(positionFirstPlayer[i]))
                                {
                                    isCommon = true;
                                    break;
                                }
                            }

                            if (isCommon)
                            {
                                long firstPl = 0;
                                long secondPl = 0;

                                foreach (var player in playerPool)
                                {
                                    if (player.Key == firstPlayer)
                                    {
                                        firstPl = player.Value.Values.Sum();
                                    }

                                    if (player.Key == secondPlayer)
                                    {
                                        secondPl = player.Value.Values.Sum();
                                    }
                                }

                                if (firstPl > secondPl)
                                {
                                    playerPool.Remove(secondPlayer);
                                }
                                else if (secondPl > firstPl)
                                {
                                    playerPool.Remove(firstPlayer);
                                }
                            }
                        }
                    }
                }

            }

            foreach (var player in playerPool.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                foreach (var position in player.Value.OrderByDescending(s => s.Value).ThenBy(n => n.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }


        }

        private static void AddPlayer(Dictionary<string, Dictionary<string, int>> playerPool, string[] tokens)
        {
            string player = tokens[0].Trim();
            string position = tokens[1].Trim();
            int skill = int.Parse(tokens[2]);

            if (playerPool.ContainsKey(player) == false)
            {
                playerPool.Add(player, new Dictionary<string, int>());
            }

            if (playerPool[player].ContainsKey(position) == false)
            {
                playerPool[player].Add(position, skill);
            }
            else
            {
                if (playerPool[player][position] < skill)
                {
                    playerPool[player][position] = skill;
                }
            }
        }
    }
}
