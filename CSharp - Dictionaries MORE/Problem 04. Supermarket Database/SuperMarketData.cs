using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_04._Supermarket_Database
{
    class SuperMarketData
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> ProductPrice = new Dictionary<string, double>();
            Dictionary<string, double> ProductCount = new Dictionary<string, double>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "stocked")
                {
                    break;
                }

                string[] tokens = line.Split().ToArray();
                string name = tokens[0];
                double price = double.Parse(tokens[1]);
                double quantity = double.Parse(tokens[2]);

                if (ProductPrice.ContainsKey(name) == false)
                {
                    ProductPrice.Add(name, 0);
                    ProductCount.Add(name, 0);
                }
                ProductPrice[name] = price;
                ProductCount[name] += quantity;
            }
            var total = 0.0;
            foreach (var product in ProductPrice)
            {
                foreach (var food in ProductCount)
                {
                    if (food.Key == product.Key)
                    {
                        var sumProduct = food.Value * product.Value;
                        Console.WriteLine($"{product.Key}: ${product.Value:F2} * {food.Value} = ${sumProduct:F2}");
                        total += sumProduct;
                    }
                }
            }
            Console.WriteLine(new string ('-', 30));
            Console.WriteLine($"Grand Total: ${total:F2}");
        }
    }
}
