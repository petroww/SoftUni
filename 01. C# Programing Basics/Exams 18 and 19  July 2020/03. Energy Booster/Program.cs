using System;

namespace EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            var Fruits = Console.ReadLine();
            var SetSize = Console.ReadLine();
            int OrderedSets = int.Parse(Console.ReadLine());

            int SmallSetSize = 2 * OrderedSets;
            int BigSetSize = 5 * OrderedSets;

            double TotalPrice = 0;

            if (Fruits == "Watermelon")
            {
                if (SetSize == "small")
                {
                    TotalPrice = TotalPrice + (SmallSetSize * 56);
                }
                else if (SetSize == "big")
                {
                    TotalPrice = TotalPrice + (BigSetSize * 28.70);

                }
            }
            else if (Fruits == "Mango")
            {
                if (SetSize == "small")
                {
                    TotalPrice = TotalPrice + (SmallSetSize * 36.66);
                }
                else if (SetSize == "big")
                {
                    TotalPrice = TotalPrice + (BigSetSize * 19.60);

                }
            }
            else if (Fruits == "Pineapple")
            {
                if (SetSize == "small")
                {
                    TotalPrice = TotalPrice + (SmallSetSize * 42.10);
                }
                else if (SetSize == "big")
                {
                    TotalPrice = TotalPrice + (BigSetSize * 24.80);

                }
            }
            if (Fruits == "Raspberry")
            {
                if (SetSize == "small")
                {
                    TotalPrice = TotalPrice + (SmallSetSize * 20);
                }
                else if (SetSize == "big")
                {
                    TotalPrice = TotalPrice + (BigSetSize * 15.20);

                }
            }
            double Discount = 0;

            if (TotalPrice >= 400 && TotalPrice <= 1000)
            {
                Discount = TotalPrice * 15 / 100;
                Console.WriteLine($"{TotalPrice - Discount:F2} lv.");
            }
            else if (TotalPrice > 1000)
            {
                Discount = TotalPrice * 50 / 100;
                Console.WriteLine($"{TotalPrice - Discount:F2} lv.");

            }
            else if (TotalPrice < 400)
                Console.WriteLine($"{TotalPrice:F2} lv.");

        }

    }
}
