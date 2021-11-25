using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_The_pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            Dictionary<string, List<string>> collection = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

                string piece = data[0];
                string composer = data[1];
                string key = data[2];


                if (!collection.ContainsKey(piece))
                {
                    collection.Add(piece, new List<string>());
                }

                collection[piece].Add(composer);
                collection[piece].Add(key);
            }

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] command = input.Split("|", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Add")
                {
                    string piece = command[1];
                    string composer = command[2];
                    string key = command[3];

                    if (collection.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        collection.Add(piece, new List<string>());
                        collection[piece].Add(composer);
                        collection[piece].Add(key);

                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                }
                else if (command[0] == "Remove")
                {
                    string piece = command[1];
                    if (collection.ContainsKey(piece))
                    {
                        collection.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                }
                else if (command[0] == "ChangeKey")
                {
                    string piece = command[1];
                    string newKey = command[2];

                    if (collection.ContainsKey(piece))
                    {
                        collection[piece][1] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }

                }

                input = Console.ReadLine();
            }

            foreach (var pair in collection.OrderBy(piece => piece.Key).ThenBy(composer => composer.Value[0]))
            {
                Console.Write($"{pair.Key} -> Composer: {pair.Value[0]}, Key: {pair.Value[1]}");
                Console.WriteLine();
            }
        }
    }
}
