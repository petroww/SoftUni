using System;

namespace FishBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budgetOfTheGroup = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countFishers = int.Parse(Console.ReadLine());

            double moneyFromRent = 0;
            double discount = 0;

            if (season.Equals("Spring"))
            {
                moneyFromRent = 3000;
            }
            else if (season.Equals("Summer") || season.Equals("Autumn"))
            {
                moneyFromRent = 4200;
            }
            else if (season.Equals("Winter"))
            {
                moneyFromRent = 2600;
            }

            if (countFishers <= 6)
            {
                discount = moneyFromRent * 0.1;
            }
            else if (countFishers > 6 && countFishers <= 11)
            {
                discount = moneyFromRent * 0.15;

            }

            else if (countFishers > 12)
            {
                discount = moneyFromRent * 0.25;
            }
            double totalprice = moneyFromRent - discount;

            double additionalyDiscount = 0;

            if (countFishers % 2 == 0 && season != "Autumn")
            {
                additionalyDiscount = totalprice * 0.05;
            }

            totalprice -= additionalyDiscount;

            if (budgetOfTheGroup >= totalprice)
            {
                Console.WriteLine($"Yes! You have {Math.Abs(budgetOfTheGroup - totalprice):f2} leva left.");
            }
            else if (budgetOfTheGroup < totalprice)
                Console.WriteLine($"Not enough money! You need {Math.Abs(totalprice - budgetOfTheGroup):f2} leva.");
        }
    }
}
