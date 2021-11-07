using System;
using System.Dynamic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var countDay = int.Parse(Console.ReadLine());

            var countCookers = int.Parse(Console.ReadLine());

            var countCakesFromOneCookerForOneDay = int.Parse(Console.ReadLine());

            var countGofreti = int.Parse(Console.ReadLine());

            var countPanCakes = int.Parse(Console.ReadLine());


            var priceForCakes = countCakesFromOneCookerForOneDay * 45;
            var priceGofreti = countGofreti * 5.80;
            var PricePanCakes = countPanCakes * 3.20;

            var priceForOneDayOneCooker = (priceForCakes + priceGofreti + PricePanCakes);
            var priceForOneDay = priceForOneDayOneCooker * countCookers;


            var priceForAllSeason = priceForOneDay * countDay;

            Console.WriteLine(priceForAllSeason - priceForAllSeason / 8);


        }
    }
}
