using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> ListWithDigits = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                string[] command = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string firstCommand = command[0];

                switch (firstCommand)
                {
                    case "Add":
                        int numberOfCommand = int.Parse(command[1]);
                        ListWithDigits.Add(numberOfCommand);
                        break;

                    case "Insert":
                        int index = int.Parse(command[2]);
                        if (index <= ListWithDigits.Count - 1 && index >= 0)
                        {
                            ListWithDigits.Insert(index, int.Parse(command[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }

                        break;

                    case "Remove":
                        if (int.Parse(command[1]) <= ListWithDigits.Count - 1 && int.Parse(command[1]) >= 0)
                        {
                            ListWithDigits.RemoveAt(int.Parse(command[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                }

                if (firstCommand == "Shift")
                {
                    string leftAndRight = command[1];
                    int count = 0;

                    switch (leftAndRight)
                    {
                        case "left":
                            count = int.Parse(command[2]);
                            for (int i = 0; i < count; i++)
                            {
                                int firstNumber = ListWithDigits[0];

                                ListWithDigits.Add(firstNumber);
                                ListWithDigits.Remove(ListWithDigits[0]);

                            }
                            break;

                        case "right":
                            count = int.Parse(command[2]);
                            for (int i = 0; i < count; i++)
                            {
                                int lastNumber = ListWithDigits[ListWithDigits.Count - 1];
                                ListWithDigits.Remove(ListWithDigits[ListWithDigits.Count - 1]);
                                ListWithDigits.Insert(ListWithDigits.IndexOf(ListWithDigits[0]), lastNumber);

                            }
                            break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", ListWithDigits));
        }
    }
}
