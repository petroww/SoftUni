using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();
            materials.Add("shards", 0);
            materials.Add("fragments", 0);
            materials.Add("motes", 0);
            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();

            bool isVallid = false;
            string text = string.Empty;
            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantityByInput = int.Parse(input[i]);
                    string keyMaterialByInput = input[i + 1].ToLower();

                    if (keyMaterialByInput == "shards" || keyMaterialByInput == "fragments" || keyMaterialByInput == "motes")
                    {
                        materials[keyMaterialByInput] += quantityByInput;
                        if (materials[keyMaterialByInput] >= 250)
                        {
                            if (keyMaterialByInput == "shards")
                            {
                                text = "Shadowmourne";
                            }
                            else if (keyMaterialByInput == "fragments")
                            {
                                text = "Valanyr";
                            }
                            else if (keyMaterialByInput == "motes")
                            {
                                text = "Dragonwrath";
                            }

                            Console.WriteLine($"{text} obtained!");
                            materials[keyMaterialByInput] -= 250;
                            isVallid = true;
                            break;
                        }

                    }
                    else
                    {
                        if (junk.ContainsKey(keyMaterialByInput))
                        {
                            junk[keyMaterialByInput] += quantityByInput;
                        }
                        else
                        {
                            junk.Add(keyMaterialByInput, quantityByInput);
                        }
                    }
                }


                if (isVallid)
                {
                    break;
                }
            }

            foreach (var elements in materials.OrderByDescending(v => v.Value).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{elements.Key}: {elements.Value}");
            }
            foreach (var junkElements in junk)
            {
                Console.WriteLine($"{junkElements.Key}: {junkElements.Value}");
            }

        }
    }
}
