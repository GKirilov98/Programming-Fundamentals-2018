using System;
using System.Text.RegularExpressions;

namespace Problem_5._Key_Replacer
{
    class Replacer
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split("<|\\".ToCharArray());
            string start = tokens[0];
            string end = tokens[2];
            string text = Console.ReadLine();
            string pattern = @"(" + start + @"(.{0,}?)" + end + @")";
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(text);
            string result = "";
            foreach (Match matche in matches)
            {
                result += matche.Groups[2];
            }

            if (result == string.Empty)
            {
                Console.WriteLine(("Empty result"));
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
