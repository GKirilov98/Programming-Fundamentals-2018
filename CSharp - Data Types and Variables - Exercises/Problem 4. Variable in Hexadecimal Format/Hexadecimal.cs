using System;

namespace Problem_4._Variable_in_Hexadecimal_Format
{
    class Hexadecimal
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int num1 = Convert.ToInt32(num, 16);
            Console.WriteLine(num1);
        }
    }
}
