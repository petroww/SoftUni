using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (var word in words)
            {
                foreach (char symbol in word)
                {
                    if (result.ContainsKey(symbol))
                    {
                        result[symbol]++;
                    }
                    else
                    {
                        result.Add(symbol, 1);
                    }
                }
            }
            foreach (var letter in result)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
