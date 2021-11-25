using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_and_Queue_EX
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputNums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> q = new Queue<int>(inputNums);

            for (int i = 0; i < nums[1]; i++)
            {
                q.Dequeue();
            }
            if (q.Contains(nums[2]))
            {
                Console.WriteLine("true");
            }
            else if (q.Count == 0)
            {
                Console.WriteLine(0);

            }
            else
            {
                Console.WriteLine(q.Min());

            }

        }
    }
}
