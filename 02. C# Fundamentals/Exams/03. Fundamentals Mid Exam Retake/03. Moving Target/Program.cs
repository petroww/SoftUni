using System;
using System.Collections.Generic;
using System.Linq;

namespace Moving_target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] comand = Console.ReadLine().Split(" ");
                if (comand[0] == "End")
                    break;

                if (comand[0] == "Shoot")
                {
                    int index = int.Parse(comand[1]);
                    int power = int.Parse(comand[2]);

                    if (index > targets.Count - 1 || index < 0)
                        continue;


                    targets[index] -= power;
                    if (targets[index] <= 0)
                    {
                        targets.RemoveAt(index);
                    }
                }

                else if (comand[0] == "Add")
                {
                    int index = int.Parse(comand[1]);
                    int value = int.Parse(comand[2]);

                    if (index > targets.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid placement!");
                        continue;
                    }
                    targets.Insert(index, value);

                }

                if (comand[0] == "Strike")
                {
                    int index = int.Parse(comand[1]);
                    int radius = int.Parse(comand[2]);

                    int removeInRange = radius * 2 + 1;
                    int removeFrom = index - radius;
                    int removeTo = index + radius;

                    if (removeFrom < 0 || removeTo > targets.Count - 1)
                    {
                        Console.WriteLine("Strike missed!");
                        continue;
                    }

                    targets.RemoveRange(removeFrom, removeInRange);

                }
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
