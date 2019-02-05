using System;

namespace Problem_2._Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string wordContains = Console.ReadLine().ToLower();
            int counter = 0;
            int index = text.IndexOf(wordContains);
            while (index != -1)
            {
                counter++;
                index = text.IndexOf(wordContains, index + 1);
            }
            Console.WriteLine(counter);
        }
    }
}
