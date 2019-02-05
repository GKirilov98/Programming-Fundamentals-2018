using System;
using System.Linq;

namespace _02._Reverse_Array_of_Integers
{
    class ReverseArrayOfInt
    {
        static void Main(string[] args)
        {
            int numOfMasive = int.Parse(Console.ReadLine());
            int[] array = GetArray(numOfMasive);
            var reversed = array.Reverse();
            Console.WriteLine(String.Join(" ", reversed));
        }

        static int[] GetArray(int numOfMasive)
        {
            int[] array = new int[numOfMasive];
            for (int i = 0; i < numOfMasive; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }
    }
}
