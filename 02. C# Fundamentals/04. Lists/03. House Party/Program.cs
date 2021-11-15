using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCommand = int.Parse(Console.ReadLine());

            List<string> listOfNames = new List<string>();

            for (int i = 0; i < numOfCommand; i++)
            {
                string line = Console.ReadLine();
                string[] command = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string goingOrNot = command[2];
                string nameCommand = command[0];

                switch (goingOrNot)
                {
                    case "going!":
                        if (!listOfNames.Contains(nameCommand))
                        {
                            listOfNames.Add(nameCommand);
                        }
                        else
                        {
                            Console.WriteLine($"{nameCommand} is already in the list!");
                        }
                        break;

                    case "not":
                        if (listOfNames.Contains(nameCommand))
                        {
                            listOfNames.Remove(nameCommand);
                        }
                        else
                        {
                            Console.WriteLine($"{nameCommand} is not in the list!");
                        }
                        break;
                }
            }

            foreach (string names in listOfNames)
            {
                Console.WriteLine(names);
            }
        }
    }
}
