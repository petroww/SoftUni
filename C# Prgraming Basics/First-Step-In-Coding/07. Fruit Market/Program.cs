using System;
using System.Dynamic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceForStrawberries = double.Parse(Console.ReadLine());

            var quantityBanana = double.Parse(Console.ReadLine());

            var quantityOrange = double.Parse(Console.ReadLine());

            var quantityRaspBerry = double.Parse(Console.ReadLine());

            var quantityStrawberry = double.Parse(Console.ReadLine());


            var PriceRaspBerry = priceForStrawberries / 2;

            var PriceOrange = PriceRaspBerry - (PriceRaspBerry * 40 / 100);

            var PriceBanana = PriceRaspBerry - (PriceRaspBerry * 80 / 100);

            var PriceStrawwBerry = quantityStrawberry * priceForStrawberries;


            Console.WriteLine(PriceStrawwBerry + PriceOrange * quantityOrange + PriceBanana * quantityBanana + PriceRaspBerry * quantityRaspBerry);

        }
    }
}
