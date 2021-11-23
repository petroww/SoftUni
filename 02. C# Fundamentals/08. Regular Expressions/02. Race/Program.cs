using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] players = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> playerByKilometers = new Dictionary<string, int>();

            while (true)
            {
                string text = Console.ReadLine();
                if (text == "end of race")
                {
                    break;
                }
                string firstPatern = @"([A-Za-z]+)";
                string secondPatern = @"(\d)";

                Regex regex = new Regex(firstPatern);
                Regex secondRegex = new Regex(secondPatern);

                var matchNames = regex.Matches(text);
                var matchDigits = secondRegex.Matches(text);

                string name = string.Empty;
                foreach (Match letter in matchNames)
                {
                    name += letter;
                }

                int kilometers = matchDigits
                    .Select(x => x.Value)
                    .Select(int.Parse)
                    .Sum();

                if (players.Contains(name))
                {
                    if (playerByKilometers.ContainsKey(name))
                    {
                        playerByKilometers[name] += kilometers;
                    }
                    else
                    {
                        playerByKilometers.Add(name, kilometers);
                    }
                }
            }
            int counter = 0;

            foreach (var item in playerByKilometers.OrderByDescending(k => k.Value))
            {
                counter++;
                if (counter == 1)
                {
                    Console.WriteLine($"{counter}st place: {item.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"{counter}nd place: {item.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"{counter}rd place: {item.Key}");
                }
                else
                {
                    break;
                }


            }
        }
    }
}
