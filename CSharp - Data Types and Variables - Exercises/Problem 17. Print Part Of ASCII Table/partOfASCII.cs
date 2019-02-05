using System;

namespace Problem_17._Print_Part_Of_ASCII_Table
{
    class partOfASCII
    {
        static void Main(string[] args)
        {
            int startChar =int.Parse(Console.ReadLine());
            int stopChar = int.Parse(Console.ReadLine());
            for (char i = (char)startChar; i <= (char) stopChar; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
