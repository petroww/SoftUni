using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string months = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceForApartment = 0;
            double priceForStudio = 0;
            double discount = 0;
            double discountForApartment = 0;

            if (months == "May" || months == "October")
            {
                priceForStudio = 50 * nights;
                priceForApartment = 65 * nights;

                if (nights > 7 && nights <= 14)
                    discount = priceForStudio * 0.05;
                else if (nights > 14)
                    discount = priceForStudio * 0.30;


            }
            else if (months == "June" || months == "September")
            {
                priceForApartment = nights * 68.7;
                priceForStudio = nights * 75.2;
                if (nights > 14)
                    discount = priceForStudio * 0.20;
            }
            else if (months == "July" || months == "August")
            {
                priceForApartment = 77 * nights;
                priceForStudio = 76 * nights;
            }

            if (nights > 14)
                discountForApartment = priceForApartment * 0.10;

            Console.WriteLine($"Apartment: {priceForApartment - discountForApartment:F2} lv.");
            Console.WriteLine($"Studio: {priceForStudio - discount:F2} lv.");
        }
    }
}
