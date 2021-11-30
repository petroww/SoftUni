using System;
using System.Collections.Generic;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> evenTimes = new Dictionary<int, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (!evenTimes.ContainsKey(input))
                {
                    evenTimes.Add(input, 0);
                }
                evenTimes[input]++;
            }

            foreach (var item in evenTimes)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
