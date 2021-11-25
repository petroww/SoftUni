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

            Stack<int> st = new Stack<int>(inputNums);

            for (int i = 0; i < nums[1]; i++)
            {
                st.Pop();
            }
            if (st.Contains(nums[2]))
            {
                Console.WriteLine("true");
            }
            else if (st.Count == 0)
            {
                Console.WriteLine(0);

            }
            else
            {
                Console.WriteLine(st.Min());

            }

        }
    }
}
