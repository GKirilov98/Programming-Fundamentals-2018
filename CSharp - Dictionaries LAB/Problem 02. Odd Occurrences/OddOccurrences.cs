using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_02._Odd_Occurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().ToLower().Split().ToList();

            var textDict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (textDict.ContainsKey(word) ==  false)
                {
                    textDict[word] = 0;
                }
                textDict[word] ++;
            }
            words.Clear();
            foreach (var item in textDict)
            {
                if (item.Value % 2 != 0)
                {
                    words.Add(item.Key);
                }
            }
            Console.WriteLine(String.Join(", ", words));
        }
    }
}
