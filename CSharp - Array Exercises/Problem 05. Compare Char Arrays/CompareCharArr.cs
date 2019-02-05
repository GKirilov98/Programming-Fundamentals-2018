using System;
using System.Linq;

namespace Problem_05._Compare_Char_Arrays
{
    class CompareCharArr
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console
                .ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
            char[] secondArr = Console
               .ReadLine()
               .Split(' ')
               .Select(char.Parse)
               .ToArray();
            int minLength = Math.Min(firstArr.Length, secondArr.Length);
            for (int i = 0; i < minLength; i++)
            {
                if (firstArr[i] < secondArr[i])
                {
                    Console.WriteLine(String.Join("", firstArr));
                    Console.WriteLine(String.Join("", secondArr));
                    return;
                }
                else if (firstArr[i] > secondArr[i])
                {
                    Console.WriteLine(String.Join("", secondArr));
                    Console.WriteLine(String.Join("", firstArr));
                    return;
                }
            }

            PrintShorter(firstArr, secondArr, minLength);
        }

        static void PrintShorter(char[] firstArr, char[] secondArr, int minLength)
        {
            if (minLength == firstArr.Length)
            {
                Console.WriteLine(String.Join("", firstArr));
                Console.WriteLine(String.Join("", secondArr));
            }
            else
            {
                Console.WriteLine(String.Join("", secondArr));
                Console.WriteLine(String.Join("", firstArr));

            }
        }
    }
}
