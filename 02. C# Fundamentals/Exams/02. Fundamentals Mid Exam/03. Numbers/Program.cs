using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            if (numbers.Count < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                double sum = numbers.Sum();
                double average = sum / (numbers.Count);

                List<int> newListNumbers = new List<int>();

                foreach (var item in numbers)
                {
                    if (item > average)
                    {
                        newListNumbers.Add(item);

                    }
                }

                newListNumbers.Sort();
                newListNumbers.Reverse();

                if (newListNumbers.Count > 5)
                {
                    while (newListNumbers.Count != 5)
                    {
                        newListNumbers.RemoveAt(newListNumbers.Count - 1);
                    }
                }

                Console.WriteLine(string.Join(" ", newListNumbers));
            }
        }
    }
}
