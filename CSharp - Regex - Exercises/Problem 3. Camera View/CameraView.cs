using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_3._Camera_View
{
    class CameraView
    {
        static void Main(string[] args)
        {
            int[] skipTake = Console.ReadLine()
                .Split()
                .Select(n => int.Parse(n))
                .ToArray();
            string text = Console.ReadLine();
            int skip = skipTake[0];
            int take = skipTake[1];
            Regex regex = new Regex(@"\|<(?<picture>\w+)");
            var matches = regex.Matches(text);
            List<string> resultWord = new List<string>();
            foreach (Match match in matches)
            {
                string sequence = match.Groups["picture"].Value;
                char[] word = sequence
                    .Skip(skip)
                    .Take(take)
                    .ToArray();
                string findedWord = new string(word);
                resultWord.Add(findedWord);
            }
            Console.WriteLine(String.Join(", ", resultWord));
        }
    }
}
