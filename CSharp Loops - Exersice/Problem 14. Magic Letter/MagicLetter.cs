using System;

namespace Problem_14._Magic_Letter
{
    class MagicLetter
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char bannedChar = char.Parse(Console.ReadLine());
            for (char i = firstChar; i <= secondChar; i++)
            {
                for (char j = firstChar; j <= secondChar; j++)
                {
                    for (char k = firstChar; k <= secondChar; k++)
                    {
                        if ( i != bannedChar && j != bannedChar && k != bannedChar)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }

                }

            }

        }
    }
}
