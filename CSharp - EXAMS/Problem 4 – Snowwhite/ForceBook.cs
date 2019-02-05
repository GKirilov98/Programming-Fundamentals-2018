using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ForceBook
{
    static void Main(string[] args)
    {
          //90 - 100
        var sideUser = new Dictionary<string, List<string>>();
        string line = Console.ReadLine();
        while (line != "Lumpawaroo")
        {
            string[] tokens = line.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length == 2)
            {
               
                string side = tokens[0].Trim();
                string user = tokens[1].Trim();
                if (sideUser.ContainsKey(side) == false)
                {
                    sideUser.Add(side, new List<string>());
                }
                if (sideUser[side].Contains(user) == false)
                {
                    sideUser[side].Add(user);
                }
            }
            else
            {
                tokens = line.Split("->",StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 2)
                {
                    string side = tokens[1].Trim();
                    string user = tokens[0].Trim();
                    if (sideUser.ContainsKey(side) == false)
                    {
                        sideUser.Add(side, new List<string>());
                    }

                    foreach (var item in sideUser)
                    {
                        if (item.Value.Contains(user))
                        {
                            item.Value.Remove(user);
                        }
                    }

                    sideUser[side].Add(user);
                    Console.WriteLine($"{user} joins the {side} side!");
                }
            }

            line = Console.ReadLine();
        }

        foreach (var side in sideUser.OrderByDescending(x => x.Value.Count()).ThenBy(n => n.Key))
        {
            if (side.Value.Count() != 0)
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count()}");
            }
           
            foreach (var user in side.Value.OrderBy(name => name))
            {
                Console.WriteLine($"! {user}");
            }
        }
    }
}