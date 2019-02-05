using System;
using System.Linq;

namespace Problem_06._Heists
{
    class Heists
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int jewels = arr[0];
            int gold = arr[1];

            int jewelCount = 0;
            int goldCount = 0;
            double sumExpenses = 0;
            while (true)
            {
                string[] loop = Console.ReadLine().Split(' ');
                if (loop[0] == "Jail" && loop[1] == "Time")
                {
                    break;
                }
                GetItems(ref jewelCount, ref goldCount, loop);
                double expenses = double.Parse(loop[1]);
                sumExpenses += expenses;
               
            }
            long information = (jewelCount * jewels) + (goldCount * gold);
            double profit = information - sumExpenses;
            if ( profit >= 0)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {profit}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(profit)}.");
            }

        }

        static void GetItems(ref int jewelCount, ref int goldCount, string[] loop)
        {
            char[] items = loop[0].ToCharArray();
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == '%')
                {
                    jewelCount++;
                }
                else if (items[i] == '$')
                {
                    goldCount++;
                }
            }
        }
    }
}
