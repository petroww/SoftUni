using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double degree = double.Parse(Console.ReadLine());
            string timeOfday = Console.ReadLine();
            string Outfit = "";
            string shoes = "";

            if (timeOfday.Equals("Morning"))
            {
                if (10 <= degree && degree <= 18)
                {
                    Outfit = "Sweatshirt";
                    shoes = "Sneakers";

                }
                else if (18 < degree && degree <= 24)
                {
                    Outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degree >= 25)
                {
                    Outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (timeOfday.Equals("Afternoon"))
            {
                if (10 <= degree && degree <= 18)
                {
                    Outfit = "Shirt";
                    shoes = "Moccasins";

                }
                else if (18 < degree && degree <= 24)
                {
                    Outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (degree >= 25)
                {
                    Outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else if (timeOfday.Equals("Evening"))
            {
                if (10 <= degree && degree <= 18)
                {
                    Outfit = "Shirt";
                    shoes = "Moccasins";

                }
                else if (18 < degree && degree <= 24)
                {
                    Outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degree >= 25)
                {
                    Outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {degree} degrees, get your {Outfit} and {shoes}.");
        }
    }
}