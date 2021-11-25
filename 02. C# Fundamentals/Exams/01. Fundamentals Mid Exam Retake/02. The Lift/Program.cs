using System;
using System.Linq;

namespace The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());

            int[] wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < wagons.Length; i++)
            {

                if (wagons[i] + peopleWaiting < 4)
                {
                    wagons[i] += peopleWaiting;
                    peopleWaiting = 0;
                }

                if (wagons[i] < 4 && peopleWaiting > 0)
                {
                    int people = 4 - wagons[i];
                    int peoplecurrentwagon = wagons[i];

                    wagons[i] = wagons[i] + (people);

                    peopleWaiting = peopleWaiting - people;
                }
                if (peopleWaiting <= 0)
                {
                    Console.WriteLine("The lift has empty spots!");
                    Console.WriteLine(string.Join(" ", wagons));
                    break;
                }
                else if (peopleWaiting > 0 && wagons[wagons.Length - 1] == 4)
                {
                    Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                    Console.WriteLine(string.Join(" ", wagons));

                }
                if (peopleWaiting == 0 && wagons[wagons.Length - 1] == 4)
                {
                    Console.WriteLine(string.Join(" ", wagons));
                    break;

                }

            }
        }
    }
}
