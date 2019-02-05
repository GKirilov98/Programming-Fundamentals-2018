using System;
using System.Collections.Generic;
using System.Numerics;

namespace Problem_1._Anonymous_Downsite
{
    class AnonDownSites
    {
        static void Main(string[] args)
        {
            List<string> sites = new List<string>();
            int n = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            Decimal siteLoss = 0M;
            for (int i = 0; i < n; i++)
            {
                string[] token = Console.ReadLine().Split();
                string siteName = token[0];
                long siteVisits = long.Parse(token[1]);
                Decimal siteCommercialPricePerVisit = Decimal.Parse(token[2]);
                siteLoss += siteVisits * siteCommercialPricePerVisit;
              
                    sites.Add(siteName);
               
            }

            Console.WriteLine(String.Join(System.Environment.NewLine, sites));
            Console.WriteLine($"Total Loss: {siteLoss:f20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(new BigInteger(securityKey), n)}");
        }
    }
}
