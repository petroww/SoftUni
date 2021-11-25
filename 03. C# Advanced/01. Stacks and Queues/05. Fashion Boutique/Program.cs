using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInBox = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int capacuty = int.Parse(Console.ReadLine());

            Stack<int> st = new Stack<int>(clothesInBox);

            int sum = 0;
            int counterRack = 0;

            while (true)
            {

                int peek = st.Peek();

                if (sum + peek <= capacuty)
                {
                    sum += st.Pop();
                    if (st.Count == 0)
                    {
                        counterRack++;
                        break;
                    }
                }
                else
                {
                    counterRack++;
                    sum = 0;
                }
            }

            Console.WriteLine(counterRack);
        }
    }
}
