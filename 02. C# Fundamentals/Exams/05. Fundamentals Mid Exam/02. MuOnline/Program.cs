using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] room = Console.ReadLine()
                 .Split("|")
                 .ToArray();


            bool flag = true;
            int health = 100;
            int bitcoins = 0;
            int bestRoom = 0;
            for (int i = 0; i < room.Length; i++)
            {
                string[] array = room[i].Split(" ").ToArray();

                string command = array[0];
                int number = int.Parse(array[1]);

                if (command == "potion")
                {
                    if (health + number > 100)
                    {
                        Console.WriteLine($"You healed for {100 - health} hp.");
                        health = 100;
                        Console.WriteLine($"Current health: {health} hp.");
                        bestRoom++;
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {number} hp.");

                        health += number;
                        Console.WriteLine($"Current health: {health} hp.");
                        bestRoom++;
                    }
                }
                else if (command == "chest")
                {
                    Console.WriteLine($"You found {number} bitcoins.");
                    bitcoins += number;
                    bestRoom++;
                }
                else
                {
                    health -= number;

                    bestRoom++;
                    if (health <= 0)
                    {

                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {bestRoom}");
                        flag = false;
                        break;
                    }
                    Console.WriteLine($"You slayed {command}.");

                }

            }

            if (flag)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }

        }
    }
}
