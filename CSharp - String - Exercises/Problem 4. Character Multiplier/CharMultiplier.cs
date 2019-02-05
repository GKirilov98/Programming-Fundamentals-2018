using System;

namespace Problem_4._Character_Multiplier
{
    class CharMultiplier
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            char[] firstWord = tokens[0].ToCharArray();
            char[] secondWord = tokens[1].ToCharArray();
            int minLenght = Math.Min(firstWord.Length, secondWord.Length);
            int sum = 0;
            for (int i = 0; i < minLenght; i++)
            {
                int result = firstWord[i] * secondWord[i];
                sum += result;
            }

            if (firstWord.Length != secondWord.Length)
            {
                int maxLenght = Math.Max(firstWord.Length, secondWord.Length);
                string longerWord = "";
                if (maxLenght == firstWord.Length)
                {
                    longerWord = new String(firstWord);
                }
                else
                {
                    longerWord = new String(secondWord);
                }
                for (int i = minLenght; i < maxLenght; i++)
                {
                    sum += longerWord[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
