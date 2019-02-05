using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_3__
{
    class Program
    {
        static void Main(string[] args)
        {//.*?%(?<name>[A-z][a-z]+?)%.*?<(?<product>.+?)>.*?[|](?<count>\d+)[|].*?(?<price>\d+[.0-9]*)[$]
            //%([A-Z][a-z]+)%.*?<(.+?)>.*?\|(\d+?)\|.*?(\d+[.]?[\d+]?)[$]
            Regex regex = new Regex("%([A-Z][a-z]+)%.*?<(.+?)>.*?\\|(\\d+?)\\|.*?(\\d+[.]?[\\d+]?)[$]");

            string line = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            while (line != "end of shift")
            {
                result.Append(line);
                line = Console.ReadLine();
            }

            var matches = regex.Matches(result.ToString());
          decimal totalIncome = 0;
            foreach (Match match in matches)
            {
                string name = match.Groups["name"].Value;
                string product = match.Groups["product"].Value;
                int count = int.Parse(match.Groups["count"].Value);
                decimal price = decimal.Parse(match.Groups["price"].Value);
                decimal totalPrice = price * count;
                totalIncome += totalPrice;
                Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");

            /* decimal totalIncome = 0;
             while (line != "end of shift")
             {
                 var match = regex.Match(line);
                 if (match.Success == false)
                 {
                     line = Console.ReadLine();
                     continue;
                 }

                 string name = match.Groups["name"].Value;
                 string product = match.Groups["product"].Value;
                 int count = int.Parse(match.Groups["count"].Value);
                 decimal price = decimal.Parse(match.Groups["price"].Value);
                 decimal totalPrice = price * count;
                 totalIncome += totalPrice;
                 Console.WriteLine($"{name}: {product} - {totalPrice:f2}");

                 line = Console.ReadLine();
             }
             Console.WriteLine($"Total income: {totalIncome:f2}");*/
        }
    }
}
