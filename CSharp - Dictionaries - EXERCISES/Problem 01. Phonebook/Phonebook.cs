using System;
using System.Collections.Generic;

namespace Problem_01._Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phoneNumbers = new SortedDictionary<string, string>();
            string[] contact = Console.ReadLine().Split();
            while (contact[0] != "END")
            {
                string command = contact[0];
               
                if(command == "A")
                {
                    string name = contact[1];
                    phoneNumbers[name] = contact[2];
                }
                else if (command == "S")
                {
                    string name = contact[1];
                    bool found = phoneNumbers.ContainsKey(name);
                    if (found)
                    {
                        foreach (var abonat in phoneNumbers)
                        {
                            if (abonat.Key == name)
                            {
                                Console.WriteLine($"{abonat.Key} -> {abonat.Value}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else
                {
                    foreach (var abonat in phoneNumbers) 
                    {
                        Console.WriteLine($"{abonat.Key} -> {abonat.Value}");
                    }
                }

                contact = Console.ReadLine().Split();
            }
        }
    }
}
