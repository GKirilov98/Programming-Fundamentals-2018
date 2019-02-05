using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_05._Parking_Validation
{
    class ParkValidation
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> nameID = new Dictionary<string, string>();
            int numCommand = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCommand; i++)
            {
                List<string> tokens = Console.ReadLine().Split().ToList();
                string command = tokens[0];
                string user = tokens[1];
                
                if (command == "register")
                {
                    string id = tokens[2];
                    Register(nameID, user, id);
                }
                else
                {
                    Unregister(nameID, user);
                }
            }
            foreach (var user in nameID)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

        static void Unregister(Dictionary<string, string> nameID, string user)
        {
            if (nameID.ContainsKey(user))
            {
                Console.WriteLine($"user {user} unregistered successfully");
                nameID.Remove(user);
            }
            else
            {
                Console.WriteLine($"ERROR: user {user} not found");
            }
        }

        static void Register(Dictionary<string, string> nameID, string user, string id)
        {
            char[] license = id.ToCharArray();
            if (license.Length != 8)
            {
                Console.WriteLine($"ERROR: invalid license plate {id}");
            }
            else
            {
                bool validID = CheckIDlicense(license);
                if (validID)
                {
                    CheckRegisterUserID(nameID, user, id);
                }
                else
                {
                    Console.WriteLine($"ERROR: invalid license plate {id}");
                }
            }
        }

        static void CheckRegisterID(Dictionary<string, string> nameID, string user, string id)
        {
            if (nameID.ContainsValue(id) == false)
            {
                nameID.Add(user, id);
                Console.WriteLine($"{user} registered {id} successfully");
            }
            else
            {
                Console.WriteLine($"ERROR: license plate {id} is busy");
            }
        }

        static void CheckRegisterUserID(Dictionary<string, string> nameID, string user, string id)
        {
            if (nameID.ContainsKey(user) == false)
            {
                CheckRegisterID(nameID, user, id);
            }
            else
            {
                Console.WriteLine($"ERROR: already registered with plate number {id}");
            }
        }

        static bool CheckIDlicense(char[] license)
        {
            if ( license[0] < 'A' || license[0] > 'Z' ||
                 license[1] < 'A' || license[1] > 'Z' ||
                 license[2] < '0' || license[2] > '9' ||
                 license[3] < '0' || license[3] > '9' ||
                 license[4] < '0' || license[4] > '9' ||
                 license[5] < '0' || license[5] > '9' ||
                 license[6] < 'A' || license[6] > 'Z' ||
                 license[7] < 'A' || license[7] > 'Z')
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
