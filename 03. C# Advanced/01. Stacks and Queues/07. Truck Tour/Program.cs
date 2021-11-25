using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> q = new Queue<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                input += $" {i}";

                q.Enqueue(input);
            }

            int totalFuel = 0;

            for (int i = 0; i < n; i++)
            {
                string current = q.Dequeue();
                int[] split = current.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int fuel = split[0];
                int kmDistance = split[1];

                totalFuel = totalFuel + fuel;

                if (totalFuel >= kmDistance)
                {
                    totalFuel -= kmDistance;
                }
                else
                {

                    totalFuel = 0;
                    i = -1;
                }
                q.Enqueue(current);

            }

            int[] split1 = q.Dequeue().Split(" ").Select(int.Parse).ToArray();
            Console.WriteLine($"{split1[2]}");

        }
    }
}
