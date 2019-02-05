using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_3___Tseam_Account
{
    class TseamAccount
    {
        static void Main(string[] args)
        {

            List<string> games = Console.ReadLine().Split().ToList();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Play!") break;

                string[] token = line.Split();
                switch (token[0])
                {
                    case "Install":
                        InstallGame(games, token);
                        break;
                    case "Uninstall":
                        Uninstall(games, token);
                        break;
                    case "Update":
                        Update(games, token);
                        break;
                    case "Expansion":
                        string game = "";
                        for (int i = 1; i < token.Length; i++)
                        {
                            game += token[i] + " ";
                        }
                        game = game.Trim();
                        string[] tokensGame = game.Split('-');
                        if (games.Contains(tokensGame[0]))
                        {
                            games.Insert(games.IndexOf(tokensGame[0]) + 1, game.Replace('-',':'));

                        }

                        break;
                }
            }

            Console.WriteLine(String.Join(" ", games));
        }

        private static void Update(List<string> games, string[] token)
        {
            string game = "";
            for (int i = 1; i < token.Length; i++)
            {
                game += token[i] + " ";
            }
            game = game.Trim();

            if (games.Contains(game))
            {
                games.Remove(game);
                games.Add(game);
            }
        }

        private static void Uninstall(List<string> games, string[] token)
        {
            string game = "";
            for (int i = 1; i < token.Length; i++)
            {
                game += token[i] + " ";
            }
            game = game.Trim();

            if (games.Contains(game))
            {
                games.Remove(game);
            }
        }

        private static void InstallGame(List<string> games, string[] token)
        {
            string game = "";
            for (int i = 1; i < token.Length; i++)
            {
                game += token[i] + " ";
            }
            game = game.Trim();
            if (games.Contains(game) == false)
            {
                games.Add(game);
            }
        }
    }
}
