using System;
using System.Collections.Generic;
namespace Problem_04._Fix_Emails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> persons = new Dictionary<string, string>();
            string name = Console.ReadLine();
            while (name != "stop")
            {
                string email = Console.ReadLine();
                if (email.Contains(".uk") || email.Contains(".us"))
                {
                    
                }
                else
                {
                    persons[name] = email;
                }
                name = Console.ReadLine();
            }

            foreach (var person in persons)
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }
        }
    }
}
