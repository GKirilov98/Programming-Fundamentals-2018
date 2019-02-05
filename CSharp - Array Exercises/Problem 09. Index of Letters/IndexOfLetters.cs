using System;
using System.Linq;

namespace Problem_09._Index_of_Letters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] charOfText = text.ToCharArray();
            for (int i = 0; i < charOfText.Length; i++)
            {
                Console.WriteLine($"{charOfText[i]} -> {(int)charOfText[i] - 97}");
            }
        }
    }
}
