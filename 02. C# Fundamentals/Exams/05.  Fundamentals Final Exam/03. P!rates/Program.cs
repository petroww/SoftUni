using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();

            string data = Console.ReadLine();

            while (data != "Sail")
            {
                string[] input = data.Split("||");

                string city = input[0];
                int population = Convert.ToInt32(input[1]);
                int gold = int.Parse(input[2]);


                if (!cities.ContainsKey(city))
                {
                    cities.Add(city, new List<int>() { population, gold });
                }
                else
                {
                    cities[city][0] += population;
                    cities[city][1] += gold;
                }
                data = Console.ReadLine();
            }

            string inputCommand = Console.ReadLine();
            while (inputCommand != "End")
            {
                string[] command = inputCommand.Split("=>");

                if (command[0] == "Plunder")
                {
                    string town = command[1];
                    int people = int.Parse(command[2]);
                    int gold = int.Parse(command[3]);

                    if (cities[town][0] - people < 1 || cities[town][1] - gold < 1)
                    {
                        cities.Remove(town);
                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                    else
                    {
                        cities[town][0] -= people;
                        cities[town][1] -= gold;
                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    }
                }
                else if (command[0] == "Prosper")
                {
                    string town = command[1];
                    int gold = int.Parse(command[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        cities[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town][1]} gold.");
                    }
                }

                inputCommand = Console.ReadLine();
            }
            bool isDictionaryEmpty = cities.Count == 0;
            if (!isDictionaryEmpty)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var town in cities.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{town.Key} -> Population: {town.Value[0]} citizens, Gold: {town.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
