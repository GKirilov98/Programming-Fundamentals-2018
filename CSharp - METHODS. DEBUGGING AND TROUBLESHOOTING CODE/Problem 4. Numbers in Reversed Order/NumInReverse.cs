using System;

namespace Problem_4._Numbers_in_Reversed_Order
{
    class NumInReverse
    {
        static void Main(string[] args)
        {
            NumReverseOrder();
        }

         static void NumReverseOrder()
        {
            string number = Console.ReadLine();
            string reversedNum = "";
            for (int  i= number.Length - 1; i>= 0; i--)
            {
                reversedNum += number[i];
            }
            Console.WriteLine(reversedNum);
        }
    }
}
