using System;
using System.Collections.Generic;
using System.Linq;

namespace Shoping_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialList = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            while (true)
            {

                string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (array[0] == "Go" && array[1] == "Shopping!")
                    break;

                string command = array[0];
                string item = string.Empty;
                if (array.Length > 1)
                {
                    item = array[1];
                }
                if (command == "Urgent")
                {
                    if (initialList.Contains(item))
                        continue;
                    else
                        initialList.Insert(0, item);
                }
                else if (command == "Unnecessary")
                {
                    if (initialList.Contains(item))
                    {
                        initialList.Remove(item);
                    }
                    else
                        continue;
                }
                else if (command == "Correct")
                {
                    string oldItem = array[1];
                    string newItem = array[2];
                    for (int i = 0; i < initialList.Count; i++)
                    {
                        if (oldItem == initialList[i])
                        {
                            initialList.RemoveAt(i);
                            initialList.Insert(i, newItem);
                        }
                    }

                }
                else if (command == "Rearrange")
                {
                    for (int i = 0; i < initialList.Count; i++)
                    {
                        if (item == initialList[i])
                        {
                            initialList.RemoveAt(i);
                            initialList.Add(item);
                            break;
                        }
                    }
                }


                if (array[0] == "show")
                    Console.WriteLine(string.Join(", ", initialList));


            }
            Console.WriteLine(string.Join(", ", initialList));
        }
    }
}
