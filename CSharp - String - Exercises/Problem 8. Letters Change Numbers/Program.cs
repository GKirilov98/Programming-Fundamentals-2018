using System;
using System.Text;
using System.Linq;
namespace Problem_8._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console
                .ReadLine()
                .Split(" \t".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            decimal sum = 0m;
            for (int i = 0; i < input.Length; i++)
            {
                string letter = input[i];
                decimal num = decimal.Parse(new string(letter
                        .Skip(1)
                        .Take(letter.Length - 2)
                        .ToArray()));
                if (letter[0] >= 'A' && letter[0] <= 'Z')
                {
                    int point = letter[0] - 64;
                    num /= point;
                }
                else
                {
                    int point = letter[0] - 96;
                    num *= point;
                }

                if (letter[letter.Length - 1] >= 'A' && letter[letter.Length - 1] <= 'Z')
                {
                    int point = letter[letter.Length - 1] - 64;
                    num -= point;
                }
                else
                {
                    int point = letter[letter.Length - 1] - 96;
                    num += point;
                }

                sum += num;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
