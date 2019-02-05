using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_09._Teamwork_projects
{
    class TeamworkProject
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            GetCreatorTeam(n, teams);
            GetTeammates(teams);


        }

        private static void GetTeammates(List<Team> teams)
        {
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end of assignment")
                {
                    break;
                }
                string[] tokens = line.Split("->");
                string user = tokens[0];
                string teamJoin = tokens[1];

                if (teams.Any(t => t.TeamName == teamJoin) == false)
                {
                    Console.WriteLine($"Team {teamJoin} does not exist!");
                    continue;
                }

                if (teams.Any(u => u.OwnerName == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamJoin}!");
                    continue;
                }

                Team team = new Team(user, teamJoin);
                teams.Add(team);
            }
        }

        private static void GetCreatorTeam(int n, List<Team> teams)
        {
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split('-');
                string owner = tokens[0];
                string nameTeam = tokens[1];

                if (teams.Any(t => t.OwnerName == owner))
                {
                    Console.WriteLine($"{owner} cannot create another team!");
                    continue;
                }

                if (teams.Any(t => t.TeamName == nameTeam))
                {
                    Console.WriteLine($"Team {nameTeam} was already created!");
                    continue;
                }

                Team team = new Team(owner, nameTeam);
                teams.Add(team);
                Console.WriteLine($"Team {nameTeam} has been created by {owner}!");
            }
        }
    }
    class Team
    {
        public string OwnerName { get; set; }

        public string TeamName { get; set; }

        public List<string> Teammates { get; set; }

        public Team(string ownerName, string teamName)
        {
            this.OwnerName = ownerName;
            this.TeamName = teamName;
            this.Teammates = new List<string>();
        }
    }
}
