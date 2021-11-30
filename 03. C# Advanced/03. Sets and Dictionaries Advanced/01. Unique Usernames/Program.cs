using System;
using System.Collections.Generic;

namespace Set_And__Dictionaries_EX
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                names.Add(input);
            }
            Console.WriteLine(string.Join("\n", names));
        }
    }
}
