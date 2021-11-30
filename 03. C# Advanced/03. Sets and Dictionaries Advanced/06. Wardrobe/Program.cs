using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe =
                new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ");

                string color = input[0];

                string[] clothes = input[1].Split(",");


                if (wardrobe.ContainsKey(color) == false)
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (var dress in clothes)
                {
                    if (!wardrobe[color].ContainsKey(dress))
                    {
                        wardrobe[color].Add(dress, 0);
                    }
                    wardrobe[color][dress]++;
                }
            }
            string[] looking = Console.ReadLine().Split();
            string lookingColor = looking[0];
            string lookingDress = looking[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var dress in color.Value)
                {

                    Console.Write($"* {dress.Key} - {dress.Value} ");
                    if (lookingColor == color.Key && lookingDress == dress.Key)
                    {
                        Console.Write($"(found!)");

                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
