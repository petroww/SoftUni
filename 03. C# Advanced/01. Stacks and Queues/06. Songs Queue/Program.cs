using System;
using System.Collections.Generic;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> q = new Queue<string>(songs);


            string input = Console.ReadLine();

            while (q.Count != 0)
            {

                if (input == "Play")
                {
                    q.Dequeue();
                }
                else if (input.Contains("Add"))
                {
                    string[] split = input.Split("Add ", StringSplitOptions.RemoveEmptyEntries);
                    if (q.Contains(split[0]))
                    {
                        Console.WriteLine($"{split[0]} is already contained!");

                    }
                    else
                        q.Enqueue(split[0]);
                }
                else if (input == "Show")
                {
                    Console.WriteLine(string.Join(", ", q));
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
