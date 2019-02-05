using System;

namespace Problem_13._Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if  ( symbol >= '0' && symbol <= '9')
            {
                Console.WriteLine("digit");
            }else if (symbol == 'A' || symbol == 'E' || symbol == 'I' || symbol == 'O' || symbol == 'U' || symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u')
            {
                Console.WriteLine("vowel");
            } else
            {
                Console.WriteLine("other");
            }
        }
    }
}
