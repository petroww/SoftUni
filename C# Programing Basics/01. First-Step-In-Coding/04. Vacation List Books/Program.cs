using System;
using System.Dynamic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var countPages = int.Parse(Console.ReadLine());

            var PagesCanbeReadForOneHour = double.Parse(Console.ReadLine());

            var daysForReading = int.Parse(Console.ReadLine());

            var hoursForReading = countPages / PagesCanbeReadForOneHour;

            var hoursForReadingForOneDay = hoursForReading / daysForReading;

            Console.WriteLine(hoursForReadingForOneDay);

        }
    }
}
