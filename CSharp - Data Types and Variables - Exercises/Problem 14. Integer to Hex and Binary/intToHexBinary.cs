using System;

namespace Problem_14._Integer_to_Hex_and_Binary
{
    class intToHexBinary
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string hexdecimal = Convert.ToString(num,16).ToUpper();
            Console.WriteLine(hexdecimal);
            string binary = Convert.ToString(num,2).ToUpper();
            Console.WriteLine(binary);
            
        }
    }
}
