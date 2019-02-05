using System;
using System.Collections.Generic;

namespace Problem_5._Magic_Exchangeable_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            string firstWord = tokens[0];
            string secondWord = tokens[1];

            if (firstWord.Length >= secondWord.Length)
            {
                ExchegeabaleWords(firstWord, secondWord);
            }
            else
            {
                ExchegeabaleWords(secondWord, firstWord);
            }

        }

        private static void ExchegeabaleWords(string wordLonger, string wordShorter)
        {
            Dictionary<char, char> map = new Dictionary<char, char>();

            for (int i = 0; i < wordShorter.Length; i++)
            {
                char firstChar = wordLonger[i];
                char secondChar = wordShorter[i];

                if (map.ContainsKey(firstChar) == false)
                {
                    map.Add(firstChar, secondChar);
                }
                else if (map[firstChar] != secondChar)
                {
                    Console.WriteLine("false");
                    return;
                }
            }

            for (int i = wordShorter.Length; i < wordLonger.Length; i++)
            {
                char charecter = wordLonger[i];
                if (map.ContainsKey(charecter) == false)
                {
                    Console.WriteLine("false");
                    return;
                }
            }

            Console.WriteLine("true");
            return;
        }
    }
}
