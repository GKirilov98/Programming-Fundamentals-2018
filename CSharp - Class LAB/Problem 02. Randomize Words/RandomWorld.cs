using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_02._Randomize_Words
{
    class RandomWorld
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            Random rnd = new Random();
            for (int i = 0; i < text.Length - 1; i++)
            {
               int index = rnd.Next(0, text.Length );
                string curr = text[i];
                text[i] = text[index];
                text[index] = curr;
            }
            Console.WriteLine(String.Join(Environment.NewLine, text));
        }
    }
}
