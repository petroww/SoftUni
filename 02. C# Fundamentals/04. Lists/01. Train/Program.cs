using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> guestsInWagon = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());


            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] command = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();



                if (command[0] == "Add")
                {
                    guestsInWagon.Add(int.Parse(command[1]));
                }
                else
                {
                    int firstIndex = 0;
                    for (int i = 0; i < guestsInWagon.Count; i++)
                    {
                        firstIndex = guestsInWagon[i] + int.Parse(command[0]);
                        if (firstIndex <= maxCapacity)
                        {
                            guestsInWagon[i] = firstIndex;
                            break;
                        }
                    }
                }


            }

            Console.WriteLine(string.Join(" ", guestsInWagon));
        }
    }
}
