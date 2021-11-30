using System;
using System.Collections.Generic;

namespace Count_Symbol
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!symbols.ContainsKey(input[i]))
                {
                    symbols.Add(input[i], 0);
                }
                symbols[input[i]]++;
            }

            foreach (var item in symbols)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
