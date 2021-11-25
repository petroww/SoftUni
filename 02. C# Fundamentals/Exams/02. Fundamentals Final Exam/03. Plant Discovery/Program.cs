using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();




            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] word = Console.ReadLine().Split("<->");

                string plant = word[0];
                int rarity = int.Parse(word[1]);

                if (!dict.ContainsKey(plant))
                {
                    dict.Add(plant, new List<double>());
                    dict[plant].Add(rarity);
                }
                else
                {
                    dict[plant][0] = rarity;

                }

            }

            string input = Console.ReadLine();

            while (input != "Exhibition")
            {
                string[] command = input.Split();

                if (command[0] == "Rate:")
                {
                    string plant = command[1];
                    int rating = int.Parse(command[3]);

                    if (dict.ContainsKey(plant))
                    {
                        dict[plant].Add(rating);
                    }
                    else
                        Console.WriteLine("error");
                }


                else if (command[0] == "Update:")
                {
                    string plant = command[1];
                    int newRarity = int.Parse(command[3]);

                    if (dict.ContainsKey(plant))
                    {
                        dict[plant][0] = newRarity;
                    }
                    else
                        Console.WriteLine("error");
                }


                else if (command[0] == "Reset:")
                {
                    string plant = command[1];

                    if (dict.ContainsKey(plant))
                    {
                        dict[plant].RemoveRange(1, dict[plant].Count - 1);
                    }
                    else
                        Console.WriteLine("error");
                }


                input = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var item in dict)
            {
                var rarity = item.Value[0];
                item.Value.RemoveAt(0);

                double sum = item.Value.Sum();

                double count = item.Value.Count;

                double average = sum / count;



                item.Value.RemoveRange(0, item.Value.Count);

                if (sum == 0)
                {
                    item.Value.Add(rarity);
                    item.Value.Add(0);
                }
                else
                {
                    item.Value.Add(rarity);
                    item.Value.Add(average);
                }
            }

            foreach (var item in dict.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1]))
            {
                Console.WriteLine($"- {item.Key}; Rarity: { (int)item.Value[0]}; Rating: { item.Value[1]:f2}");

            }
        }
    }
}
