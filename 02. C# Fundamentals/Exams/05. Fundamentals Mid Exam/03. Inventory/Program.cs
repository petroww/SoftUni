using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            while (true)
            {
                string[] line = Console.ReadLine().Split(" - ").ToArray();
                if (line[0] == "Craft!")
                {
                    break;

                }

                string command = line[0];

                string item = line[1];


                if (command == "Collect")
                {
                    bool flagCheck = false;
                    /*
                    foreach (var itemFromInventory in inventory)
                    {
                        if(itemFromInventory == item)
                        {
                            flagCheck = true;
                        }    
                    }
                    if(flagCheck == false)
                    {
                        inventory.Add(item);
                    }
                    */
                    if (inventory.Contains(item))
                    {
                        flagCheck = true;
                    }
                    if (flagCheck == false)
                    {
                        inventory.Add(item);
                    }
                }
                else if (command == "Drop")
                {
                    /*
                    for (int j = 0; j < inventory.Count; j++)
                    {
                        if (inventory[j] == item)
                        {
                            inventory.RemoveAt(j);
                        }
                    }
                    */
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                    }
                }
                else if (command == "Combine Items")
                {
                    string[] combineItem = item.Split(":");
                    string oldItem = combineItem[0];
                    string newItem = combineItem[1];


                    for (int k = 0; k < inventory.Count; k++)
                    {
                        if (oldItem == inventory[k])
                        {
                            inventory.Insert(k + 1, newItem);
                        }
                    }
                }
                else if (command == "Renew")
                {
                    /*for (int i = 0; i < inventory.Count; i++)
                    {
                        if(inventory[i] == item)
                        {
                            inventory.Add(item);
                            inventory.RemoveAt(i);

                        }
                    }*/

                    if (inventory.Contains(item))
                    {
                        inventory.Add(item);
                        inventory.Remove(item);
                    }
                }

            }
            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
