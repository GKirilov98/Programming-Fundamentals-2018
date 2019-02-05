using System;
using System.Linq;

namespace Problem_07._Inventory_Matcher
{
    class InventoryMatcher
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ');
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            while (true)
            {
                string food = Console.ReadLine();
                if (food == "done")
                {
                    break;
                }
               int index = Array.IndexOf(products, food);
                Console.WriteLine($"{food} costs: {price[index]}; Available quantity: {quantities[index]}");
            }
        }
    }
}
