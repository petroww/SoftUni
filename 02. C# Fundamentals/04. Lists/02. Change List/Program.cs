using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> digits = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

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

                string firstCommand = command[0];

                switch (firstCommand)
                {
                    case "Delete":
                        digits.RemoveAll(n => n == int.Parse(command[1]));
                        break;

                    case "Insert":
                        digits.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", digits));
        }
    }
}
