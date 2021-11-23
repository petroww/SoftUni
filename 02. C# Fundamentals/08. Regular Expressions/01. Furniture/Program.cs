using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> furnitureByPrice = new Dictionary<string, double>();

            while (true)
            {
                string furniture = Console.ReadLine();
                if (furniture == "Purchase")
                {
                    break;
                }

                string patern = @"^>>([A-za-z]+)<<(\d{1,}\.\d{1,}|\d{1,})\!(\d{1,})$";
                Regex regex = new Regex(patern);
                var match = regex.Matches(furniture);
                ;

                if (regex.IsMatch(furniture))
                {
                    foreach (Match element in match)
                    {
                        furnitureByPrice.Add(element.Groups[1].Value, double.Parse(element.Groups[2].Value) * double.Parse(element.Groups[3].Value));
                    }
                }
            }
            double totalMoney = 0;
            Console.WriteLine("Bought furniture:");
            foreach (var name in furnitureByPrice)
            {
                totalMoney += name.Value;
                Console.WriteLine(name.Key);
            }
            Console.WriteLine($"Total money spend: {totalMoney:F2}");
            
        }
    }
}
