using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex(@"([=|\/])(?<destination>[A-Z][A-Za-z]{2,})\1");

            string text = Console.ReadLine();

            MatchCollection matchess = reg.Matches(text);
            int countPoints = 0;



            List<string> countries = new List<string>();

            foreach (Match country in matchess)
            {

                countries.Add(country.Groups["destination"].Value);
                countPoints += country.Groups["destination"].Length;
            }

            Console.Write("Destinations: ");
            Console.WriteLine(string.Join(", ", countries));

            Console.WriteLine($"Travel Points: {countPoints}");

        }
    }
}
