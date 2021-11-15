using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> digit = new List<string>();

            for (int i = arrays.Count - 1; i >= 0; i--)
            {
                string[] numbers = arrays[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);

                digit.AddRange(numbers);
            }
            Console.WriteLine(string.Join(" ", digit));


        }
    }
}
