using System;
using System.Collections.Generic;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Lumpawaroo")
                {
                    break;
                }
                string forceSide = string.Empty;
                string forceUser = string.Empty;

                if (line.Contains('|'))
                {
                    // {forceSide} | {forceUser}
                    string[] firstParts = line
                        .Split(" | ", StringSplitOptions.RemoveEmptyEntries);

                    forceSide = firstParts[0];
                    forceUser = firstParts[1];

                    if (!forceBook.ContainsKey(forceSide))
                    {
                        forceBook.Add(forceSide, new List<string>() { forceUser });
                    }


                }
                else if (line.Contains("->"))
                {
                    // {forceUser} -> {forceSide}
                    string[] secondParts = line
                        .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                    forceUser = secondParts[0];
                    forceSide = secondParts[1];

                    if (!forceBook.ContainsKey(forceUser))
                    {
                        forceBook[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else
                    {
                        forceBook[forceSide].Add(forceUser);
                    }



                }

               
            }
        }
    }
}
