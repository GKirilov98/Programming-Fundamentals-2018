using System;
using System.Linq;

namespace Problem_04._Grab_and_Go
{
    class GrabAndGo
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long num = int.Parse(Console.ReadLine());

            int counter = 0;
            long sum = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == num)
                {
                    counter++;
                    for (int j = 0; j < i; j++)
                    {
                        sum += arr[j];
                    }
                        break;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
