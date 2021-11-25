using System;
using System.Collections.Generic;
using System.Linq;

namespace Shoot_for_the_Win
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
                string input = Console.ReadLine();
                if (input == "End")
                    break;
                int index = int.Parse(input);



                if (index > targets.Count - 1)
                {
                    continue;
                }

                int numFromIndex = targets[index];
                targets[index] = -1;

                for (int i = 0; i < targets.Count; i++)
                {

                    if (numFromIndex < targets[i])
                    {
                        if (targets[i] == -1)
                        {
                            continue;
                        }

                        targets[i] -= numFromIndex;
                    }
                    else if (numFromIndex >= targets[i])
                    {
                        if (targets[i] == -1)
                        {
                            continue;
                        }

                        targets[i] += numFromIndex;

                    }
                }
            }
            int count = 0;
            foreach (var item in targets)
            {
                if (item == -1)
                    count++;
            }
            Console.Write($"Shot targets: {count} -> ");
            Console.Write(string.Join(" ", targets));
        }
    }
}
