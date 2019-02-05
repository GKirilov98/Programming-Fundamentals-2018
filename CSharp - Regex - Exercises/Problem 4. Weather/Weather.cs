using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
namespace Problem_4._Weather
{
    class Weather
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<city>[A-Z]{2})(?<temp>\d+\.\d+)(?<weather>[A-Za-z]+)\|");
            string line = Console.ReadLine();
            var cities = new Dictionary<string, KeyValuePair<double, string>>();
            while (line != "end")
            {
                    MatchCollection matches = regex.Matches(line);
                    FillDic(cities, matches);

                line = Console.ReadLine();
            }

            foreach (var city in cities.OrderBy(x => x.Value.Value))
            {
                Console.WriteLine($"{city.Key} => {city.Value.Key:f2} => {city.Value.Value}");
            }

        }

        static void FillDic(Dictionary<string, KeyValuePair<double, string>> cities, MatchCollection matches)
        {
            foreach (Match match in matches)
            {
                string city = match.Groups["city"].Value;
                string weather = match.Groups["weather"].Value;
                double temp = double.Parse(match.Groups["temp"].Value);
                if (cities.ContainsKey(city) == false)
                {
                    cities.Add(city, new KeyValuePair<double, string>(temp, weather));
                }

                cities[city] = new KeyValuePair<double, string>(temp, weather);
            }
        }
    }
}
