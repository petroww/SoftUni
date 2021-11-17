using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registeredByUsers = new Dictionary<string, string>();

            int nLineCommands = int.Parse(Console.ReadLine());
            string plateNumber = string.Empty;

            for (int i = 0; i < nLineCommands; i++)
            {
                string[] cmArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmArgs[0];
                string name = cmArgs[1];

                switch (command)
                {
                    case "register":
                        if (!registeredByUsers.ContainsKey(name))
                        {
                            plateNumber = cmArgs[2];
                            registeredByUsers.Add(name, plateNumber);
                            Console.WriteLine($"{name} registered {plateNumber} successfully");
                            
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                        }
                        break;
                    case "unregister":
                        if (!registeredByUsers.ContainsKey(name))
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }
                        else
                        {
                            
                            Console.WriteLine($"{name} unregistered successfully");
                            registeredByUsers.Remove(name);
                        }
                        break;
                }
            }

            foreach (var element in registeredByUsers)
            {
                Console.WriteLine($"{element.Key} => {element.Value}");
            }
        }
    }
}
