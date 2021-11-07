using System;

namespace FitnesCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double PriceWeHave = double.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            var sport = Console.ReadLine();

            double totalPrice = 0;
            double discount = 0;

            if (sex == 'm')
            {
                if (sport == "Gym")
                {
                    totalPrice = 42;
                    if (age <= 19)
                    {
                        discount = totalPrice * 0.20;
                        totalPrice = totalPrice - discount;
                    }

                }
                else if (sport == "Boxing")
                {
                    totalPrice = 41;
                    if (age <= 19)
                    {
                        discount = totalPrice * 0.20;
                        totalPrice = totalPrice - discount;
                    }
                }
                else if (sport == "Yoga")
                {
                    totalPrice = 45;
                    if (age <= 19)
                    {
                        discount = totalPrice * 0.20;
                        totalPrice = totalPrice - discount;
                    }
                }
                else if (sport == "Zumba")
                {
                    totalPrice = 34;
                    if (age <= 19)
                    {
                        discount = totalPrice * 0.20;
                        totalPrice = totalPrice - discount;
                    }
                }
                else if (sport == "Dances")
                {
                    totalPrice = 51;
                    if (age <= 19)
                    {
                        discount = totalPrice * 0.20;
                        totalPrice = totalPrice - discount;
                    }
                }
                else if (sport == "Pilates")
                {
                    totalPrice = 39;
                    if (age <= 19)
                    {
                        discount = totalPrice * 0.20;
                        totalPrice = totalPrice - discount;
                    }
                }
            }

            if (sex == 'f')
            {
                if (sport == "Gym")
                {
                    totalPrice = 35;
                    if (age <= 19)
                    {
                        discount = totalPrice * 0.20;
                        totalPrice = totalPrice - discount;
                    }

                }
                else if (sport == "Boxing")
                {
                    totalPrice = 37;
                    if (age <= 19)
                    {
                        discount = totalPrice * 0.20;
                        totalPrice = totalPrice - discount;
                    }
                }
                else if (sport == "Yoga")
                {
                    totalPrice = 42;
                    if (age <= 19)
                    {
                        discount = totalPrice * 0.20;
                        totalPrice = totalPrice - discount;
                    }
                }
                else if (sport == "Zumba")
                {
                    totalPrice = 31;
                    if (age <= 19)
                    {
                        discount = totalPrice * 0.20;
                        totalPrice = totalPrice - discount;
                    }
                }
                else if (sport == "Dances")
                {
                    totalPrice = 53;
                    if (age <= 19)
                    {
                        discount = totalPrice * 0.20;
                        totalPrice = totalPrice - discount;
                    }
                }
                else if (sport == "Pilates")
                {
                    totalPrice = 37;
                    if (age <= 19)
                    {
                        discount = totalPrice * 0.20;
                        totalPrice = totalPrice - discount;
                    }
                }
            }

            if (PriceWeHave >= totalPrice)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
                Console.WriteLine($"You don't have enough money! You need ${totalPrice - PriceWeHave:F2} more.");
        }
    }
}
