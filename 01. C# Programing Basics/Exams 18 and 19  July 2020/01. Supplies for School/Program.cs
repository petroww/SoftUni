using System;

namespace SupliesFroSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int marker = int.Parse(Console.ReadLine());
            double litriChemichals = double.Parse(Console.ReadLine());
            int percentOfDiscount = int.Parse(Console.ReadLine());

            double PriceForPens = pens * 5.80;
            double PriceForMarkers = marker * 7.20;
            double PriceChemicals = litriChemichals * 1.20;

            double sum = PriceForPens + PriceForMarkers + PriceChemicals;
            double discoint = sum * percentOfDiscount / 100;

            double totalPrice = sum - discoint;

            Console.WriteLine($"{totalPrice:F3}");
        }
    }
}
