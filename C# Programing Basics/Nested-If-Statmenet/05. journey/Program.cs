using System;

namespace jurney
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double spentMoney = 0;
            string whereWillBeTheHoliday = "";
            string typeRoom = "";

            if (budget <= 100)
            {
                whereWillBeTheHoliday = "Bulgaria";
                if (season == "summer")
                {
                    spentMoney = budget * 0.30;
                    typeRoom = "Camp";
                }
                else if (season == "winter")
                {
                    spentMoney = budget * 0.70;
                    typeRoom = "Hotel";
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                whereWillBeTheHoliday = "Balkans";
                if (season == "summer")
                {
                    spentMoney = budget * 0.40;
                    typeRoom = "Camp";
                }
                else if (season == "winter")
                {
                    spentMoney = budget * 0.80;
                    typeRoom = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                whereWillBeTheHoliday = "Europe";
                typeRoom = "Hotel";
                if (season == "summer")
                {
                    spentMoney = budget * 0.90;
                }
                else if (season == "winter")
                {
                    spentMoney = budget * 0.90;
                }
            }

            Console.WriteLine($"Somewhere in {whereWillBeTheHoliday}");
            Console.WriteLine($"{typeRoom} - {spentMoney:f2}");
        }
    }
}
