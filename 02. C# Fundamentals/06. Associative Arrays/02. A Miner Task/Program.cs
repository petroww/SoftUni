using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;

                }
                int quantity = int.Parse(Console.ReadLine());

                if (!result.ContainsKey(resource))
                {
                    result.Add(resource, quantity);
                }
                else
                {
                    result[resource] += quantity;
                }
            }

            foreach (var resources in result)
            {
                Console.WriteLine($"{resources.Key} -> {resources.Value}");
            }

        }
    }
}
