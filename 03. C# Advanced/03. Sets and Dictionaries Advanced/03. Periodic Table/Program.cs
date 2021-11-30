using System;
using System.Collections.Generic;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            SortedSet<string> periodicTable = new SortedSet<string>();

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                foreach (var item in input)
                {
                    periodicTable.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", periodicTable));
        }
    }
}
