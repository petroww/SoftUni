using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodAvailability = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> q = new Queue<int>(orders);

            int maxOrder = q.Max();
            while (q.Count > 0)
            {
                int peek = q.Peek();

                if (foodAvailability - peek < 0)
                {
                    break;
                }
                foodAvailability -= q.Dequeue();
            }
            Console.WriteLine(maxOrder);

            if (q.Count == 0)
            {

                Console.Write("Orders complete");
            }
            else
            {
                Console.Write("Orders left: ");
                Console.WriteLine(string.Join(" ", q));

            }
        }
    }
}
