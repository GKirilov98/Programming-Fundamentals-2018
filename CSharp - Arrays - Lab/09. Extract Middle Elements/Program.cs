using System;
using System.Linq;

namespace _09._Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            PrintArrayMidle(arr);
        }

         static void PrintArrayMidle(int[] arr)
        {
            if (arr.Length == 1)
            {
                Console.WriteLine(arr[0]);
            }
            else if (arr.Length % 2 == 0)
            {
                EvenArray(arr);
            }
            else
            {
                OddArray(arr);
            }
        }

        static void OddArray(int[] arr)
        {
            int secondNum = arr.Length / 2;
            int firstNum = secondNum - 1;
            int thirdNum = secondNum + 1;
            Console.WriteLine(arr[firstNum] + " " + arr[secondNum] + " " + arr[thirdNum]);

        }

        static void EvenArray(int[] arr)
        {
            int secondNum = arr.Length / 2;
            int firstNum = secondNum - 1;
            Console.WriteLine(arr[firstNum] + " " + arr[secondNum]);
        }
    }
}
