using System;
using System.Linq;

namespace _06._Reverse_Array_of_Strings
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            var reversed = arr.Reverse();
            Console.WriteLine(String.Join(" ", reversed));
        }
    }
}
