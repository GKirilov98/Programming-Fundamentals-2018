using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_2___Memory_View
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Visual Studio crash")
                {
                    break;
                }

                result.Append(" " + line);
            }

            Regex regex = new Regex(@"32656 19759 32763 0 \d+ 0 ([\d+ ]+?) 0");
            var matches = regex.Matches(result.ToString());

            foreach (Match match in matches)
            {
                string[] word = match.Groups[1].ToString().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string text = string.Empty;
                for (int i = 0; i < word.Length; i++)
                {
                    text += (char)(int.Parse(word[i]));
                }
                Console.WriteLine(text);
            }
        }
    }
}
