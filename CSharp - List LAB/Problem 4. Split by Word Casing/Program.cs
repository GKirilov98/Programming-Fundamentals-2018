using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console
                .ReadLine()
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' },  StringSplitOptions.RemoveEmptyEntries);

            List<string> lowercase = new List<string>();
            List<string> mixedcase = new List<string>();
            List<string> uppercase = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
              if (text[i].All(char.IsLower))
                {
                    lowercase.Add(text[i]);
                }
              else if (text[i].All(char.IsUpper))
                {
                    uppercase.Add(text[i]);
                }
              else
                {
                    mixedcase.Add(text[i]);
                }
            }

            Console.WriteLine($"Lower-case: {String.Join(", ",lowercase)}\r\n" +
                              $"Mixed-case: {String.Join(", ", mixedcase)}\r\n" +
                              $"Upper-case: {String.Join(", ", uppercase)}\r\n");
        }
    }
}

