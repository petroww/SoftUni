using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceDeposit = double.Parse(Console.ReadLine());

            var month = double.Parse(Console.ReadLine());

            var incrase = double.Parse(Console.ReadLine());

            var accruetIncrease = priceDeposit * incrase / 100;

            var increaseForAMonth = accruetIncrease / 12;

            var totalIncrase = increaseForAMonth * month;

            Console.WriteLine(priceDeposit + totalIncrase);




        }
    }
}
