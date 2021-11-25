using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> st = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (input[0] == 1)
                {
                    int numToPush = input[1];

                    st.Push(numToPush);
                }
                else if (input[0] == 2)
                {
                    if (st.Count > 0)
                        st.Pop();
                    else
                        continue;
                }
                else if (input[0] == 3)
                {
                    if (st.Count > 0)
                        Console.WriteLine(st.Max());
                    else
                        continue;
                }
                else if (input[0] == 4)
                {
                    if (st.Count > 0)
                        Console.WriteLine(st.Min());
                    else
                        continue;
                }

            }
            Console.WriteLine(string.Join(", ", st));
        }
    }
}
