using System;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int BitCoin = int.Parse(Console.ReadLine());
            double ChineIoan = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double PriceForBitCoin = BitCoin * 1168;
            double PriceForIoan = (ChineIoan * 0.15) * 1.76;

            double sum = PriceForBitCoin + PriceForIoan;
            double PriceForCommision = sum * commision / 100;

            double totalPrice = sum - PriceForCommision;
            totalPrice = totalPrice / 1.95;

            Console.WriteLine($"{totalPrice:F2}");

        }
    }
}
