using System;
using System.Text.RegularExpressions;

namespace Problem_3___Snowflake
{
    class SnowFlake
    {
        static void Main(string[] args)
        {
            Regex smcorePatt = new Regex(@"^([^A-Za-z0-9]+)([\d+_]+)([A-Za-z]+)([\d+_]+)[^A-Za-z0-9]+?$");
            Regex mantlePatt = new Regex(@"^(?<mantle>[\d+_]+)$");
            Regex surfacePatt = new Regex(@"^(?<surface>[^A-Za-z0-9]+)$");

            string surface1 = Console.ReadLine();
            string mantle1 = Console.ReadLine();
            string core = Console.ReadLine();
            string mantle2 = Console.ReadLine();
            string surface2 = Console.ReadLine();

            var macthSurface1 = surfacePatt.Match(surface1);
            var macthSurface2 = surfacePatt.Match(surface2);
            var matchMantle1 = mantlePatt.Match(mantle1);
            var matchMantle2 = mantlePatt.Match(mantle2);
            var matchCore = smcorePatt.Match(core);

            if (macthSurface1.Success && macthSurface2.Success &&
                matchMantle1.Success && matchMantle2.Success &&
                matchCore.Success)
            {
                var matches = smcorePatt.Match(core);
                var count = matches.Groups[3].Length;
                Console.WriteLine("Valid");
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
