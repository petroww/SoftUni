using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lenght = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            HashSet<int> n = new HashSet<int>();
            HashSet<int> m = new HashSet<int>();

            for (int i = 0; i < lenght[0]; i++)
            {
                int input = int.Parse(Console.ReadLine());
                n.Add(input);
            }
            for (int i = 0; i < lenght[1]; i++)
            {
                int input = int.Parse(Console.ReadLine());
                m.Add(input);
            }

            var r = n.Intersect(m);
            foreach (var item in r)
            {
                Console.Write(item + " ");
            }
        }
    }
}
