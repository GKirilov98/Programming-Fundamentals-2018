using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4___Snowwhite
{
    class Snowwhite
    {
        static void Main(string[] args)
        {
            var colorNamePhysic = new Dictionary<string, Dictionary<string, int>>();
            string line = Console.ReadLine();
            while (line != "Once upon a time")
            {
                string[] tokens = line.Split("<:>".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0].Trim();
                string hatColor = tokens[1].Trim();
                int physic = int.Parse(tokens[2]);
                if (colorNamePhysic.ContainsKey(hatColor) == false)
                {
                    colorNamePhysic.Add(hatColor, new Dictionary<string, int>());
                }

                if (colorNamePhysic[hatColor].ContainsKey(name) == false)
                {
                    colorNamePhysic[hatColor].Add(name, physic);
                }
                else
                {
                    if (colorNamePhysic[hatColor][name] < physic)
                    {
                        colorNamePhysic[hatColor][name] = physic;
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var item in colorNamePhysic.OrderByDescending(p => p.Value.Values.Max()).ThenByDescending(x => x.Key.))
            {
                foreach (var c in item.Value)
                {

                    Console.WriteLine($"({item.Key}) {c.Key} <-> {c.Value}");
                }
            }

            //List<Dwarf> dwarfList = new List<Dwarf>();
            //string line = Console.ReadLine();
            //while (line != "Once upon a time")
            //{


            //    string[] tokens = line.Split("<:>");
            //    string name = tokens[0].Trim();
            //    string color = tokens[1].Trim();
            //    long physic = long.Parse(tokens[2]);

            //    Dwarf dwarf = new Dwarf(name, color, physic);



            //    foreach (var item in dwarfList)
            //    {
            //        if (item.Name == name &&
            //            item.Color == color &&
            //            item.Physic < physic)
            //        {
            //            item.Physic = physic;
            //            break;
            //        }

            //    }
            //    line = Console.ReadLine();
            //}
            //foreach (var item in dwarfList.OrderByDescending(p => p.Physic).ThenByDescending(c => c.Color.Any()))
            //{
            //    Console.WriteLine($"({item.Color}) {item.Name} <-> {item.Physic}");
            //}
        }
    }

    class Dwarf
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public long Physic { get; set; }

        public Dwarf(string name, string color, long physic)
        {
            this.Name = name;
            this.Color = color;
            this.Physic = physic;
        }
    }
}

