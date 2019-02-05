using System;
using System.Collections.Generic;

namespace Problem_3._Unicode_Characters
{
    class Unicode
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<string> result = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                string unicode = "\\u" + ((int)text[i]).ToString("x4");
                result.Add(unicode);
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
