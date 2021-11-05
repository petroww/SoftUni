using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlowers = Console.ReadLine();
            int countFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double discount = 0;
            double totalPrice = 0;

            if (typeFlowers.Equals("Roses"))
            {
                totalPrice = 5 * countFlowers;
                if (countFlowers > 80)
                    discount = totalPrice * 0.1;
            }
            else if (typeFlowers.Equals("Dahlias"))
            {
                totalPrice = 3.8 * countFlowers;
                if (countFlowers > 90)
                    discount = totalPrice * 0.15;
            }
            else if (typeFlowers == "Tulips")
            {
                totalPrice = 2.8 * countFlowers;
                if (countFlowers > 80)
                    discount = totalPrice * 0.15;
            }
            else if (typeFlowers == "Narcissus")
            {
                totalPrice = 3 * countFlowers;
                if (countFlowers < 120)
                    totalPrice += totalPrice * 0.15;
            }
            else if (typeFlowers == "Gladiolus")
            {
                totalPrice = 2.5 * countFlowers;
                if (countFlowers < 80)
                    totalPrice += totalPrice * 0.20;
            }

            totalPrice -= discount;

            if (budget < totalPrice)
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:F2} leva more.");
            else
                Console.WriteLine($"Hey, you have a great garden with {countFlowers} {typeFlowers} and {budget - totalPrice:F2} leva left.");

        }
    }
}
