using System;
using System.Collections.Generic;
using System.Linq;

namespace Memmory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int countMoves = 0;

            string input = string.Empty;
            bool flagForBreak = true;

            while ((input = Console.ReadLine()) != "end")
            {
                int[] convert = input.
                    Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                countMoves++;

                int indexA = convert[0];
                int indexB = convert[1];

                bool indexACheck = indexA >= 0 && indexA < numbers.Count;
                bool indexBCheck = indexB >= 0 && indexB < numbers.Count;
                bool notEqualIndexes = indexA != indexB;

                if (indexACheck == false || indexBCheck == false || notEqualIndexes == false)
                {
                    Console.WriteLine($"Invalid input! Adding additional elements to the board");
                    int insertIndex = numbers.Count / 2;

                    numbers.Insert(insertIndex, $"-{countMoves}a");
                    numbers.Insert(insertIndex, $"-{countMoves}a");
                }
                else
                {
                    if (numbers[indexA] == numbers[indexB])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {numbers[indexA]}!");

                        string itemToRemove = numbers[indexA];

                        numbers.RemoveAll(items => items == itemToRemove);

                        bool listIsEmpty = !numbers.Any();
                        if (listIsEmpty)
                        {
                            Console.WriteLine($"You have won in {countMoves} turns!");
                            flagForBreak = false;
                            break;

                        }
                    }

                    else
                    {
                        Console.WriteLine("Try again!");
                    }

                }

            }
            if (flagForBreak == true)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", numbers));
            }

        }
    }
}
