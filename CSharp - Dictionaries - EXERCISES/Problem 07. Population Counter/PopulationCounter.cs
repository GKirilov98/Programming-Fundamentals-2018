using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_07._Population_Counter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            var countryPopulations = new Dictionary<string, long>();
            var cCP = new Dictionary<string, Dictionary<string, long>>();
            string line = Console.ReadLine();
            while (line != "report")
            {
                FillDictionaries(countryPopulations, cCP, line);
                line = Console.ReadLine();
            }

            PrintCountryPopulations(countryPopulations, cCP);

        }

        static void PrintCountryPopulations(Dictionary<string, long> countryPopulations, Dictionary<string, Dictionary<string, long>> cCP)
        {
            foreach (var country in countryPopulations.OrderByDescending(c => c.Value))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");
                Dictionary<string, long> cities = cCP[country.Key]
                    .OrderByDescending(c => c.Value)
                    .ToDictionary(c => c.Key, c => c.Value);
                foreach (var city in cities)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }

        static void FillDictionaries(Dictionary<string, long> countryPopulations, Dictionary<string, Dictionary<string, long>> cCP, string line)
        {
            string[] tokens = line.Split('|').ToArray();
            string country = tokens[1];
            string city = tokens[0];
            long popuCity = long.Parse(tokens[2]);
            if (cCP.ContainsKey(country) == false)
            {
                countryPopulations.Add(country, 0);
                cCP.Add(country, new Dictionary<string, long>());
            }

            cCP[country][city] = popuCity;
            countryPopulations[country] += popuCity;
        }
    }
}
