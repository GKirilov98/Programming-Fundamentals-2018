using System;

namespace Problem_7._Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before:\r\na = {num1}\r\nb = {num2}");
            Console.WriteLine($"After:\r\na = {num2}\r\nb = {num1}");

        }
    }
}
