using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_4__
{
    class Program
    {
        static void Main(string[] args)
        {
            var languageCount = new SortedDictionary<string, int>();
            var usernameLanguagePoints = new SortedDictionary<string, int>();

            string line = Console.ReadLine();
            while (line != "exam finished")
            {
                string[] tokens = line.Split('-');
                if (tokens.Length == 3)
                {
                    string username = tokens[0];
                    string language = tokens[1];
                    int points = int.Parse(tokens[2]);
                    //User 
                    if (usernameLanguagePoints.ContainsKey(username) == false)
                    {
                        usernameLanguagePoints.Add(username, points);
                    }
                    ////Language
                    //if (usernameLanguagePoints[username].ContainsKey(language) == false)
                    //{
                    //    usernameLanguagePoints[username].Add(language, points);
                    //}
                    //Points
                    if (usernameLanguagePoints[username] < points)
                    {
                        usernameLanguagePoints[username] = points;
                    }
                    //Language Count
                    if (languageCount.ContainsKey(language) == false)
                    {
                        languageCount.Add(language, 0);
                    }
                    //Count ++;
                    languageCount[language]++;
                }
                else
                {
                    string username = tokens[0];
                    if (usernameLanguagePoints.ContainsKey(username))
                    {
                        usernameLanguagePoints.Remove(username);
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            foreach (var user in usernameLanguagePoints.OrderByDescending(p => p.Value))
            {
                Console.WriteLine(user.Key + " | " + user.Value);
            }

            Console.WriteLine("Submissions:");
            foreach (var lan in languageCount.OrderByDescending(x => x.Value))
            {
                Console.WriteLine(lan.Key + " - " + lan.Value);
            }
        }
    }
}
