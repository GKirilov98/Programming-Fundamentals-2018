using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_2._Extract_Sentences_by_Keyword
{
    class Keyword
    {
        static void Main(string[] args)
        {
            string serchedWord = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = $@"\b{serchedWord}\b";
            Regex regex = new Regex(pattern);
            string[] sequences = text.Split(".!?".ToCharArray());
            foreach (string sequence in sequences)
            {
                if (regex.IsMatch(sequence))
                {
                    Console.WriteLine(sequence.Trim());
                }
            }
        }
    }
}
