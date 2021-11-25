using System;
using System.Text.RegularExpressions;

namespace Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regex = new Regex(@"([#|\|])(?<item>[a-zA-z\s*]+)\1(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<calories>\d+)\1");

            MatchCollection matchess = regex.Matches(text);

            int totalCalories = 0;

            foreach (Match match in matchess)
            {
                totalCalories += Convert.ToInt32(match.Groups["calories"].Value);
            }

            int days = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match match in matchess)
            {
                Console.Write(
                    $"Item: {match.Groups["item"].Value}, Best before: " +
                    $"{match.Groups["date"].Value}, Nutrition: " +
                    $"{match.Groups["calories"].Value}");
                Console.WriteLine();
            }

        }


    }

}
